using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark << 2) ^ mark;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark * 5) + ((long)i >> 1)) - (long)i2;
                    mark = mark - (mark * 3);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((hits + 2) != (step % 100)) || (step < (entry & 127))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                anchor = ((anchor - (anchor / 9)) % 65521) ^ entry;
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor * 2)) % 4096;
            }
            return anchor;
        }
    }
}
