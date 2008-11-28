using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double rate2 = 7.0;
            if (rate2 < (double)4)
            {
                rate2 = rate2 - (2.76 * 9.95);
            }
            else
            {
                rate2 = rate2 - 5.39;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (bias * 0.8)) + (double)(long)i;
            }
            return rate2 + (rate + bias);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((35 - value) > (4 >> 3))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
