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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((long)i >= acc)
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ (offset - acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= span)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - (span / 8.0);
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
