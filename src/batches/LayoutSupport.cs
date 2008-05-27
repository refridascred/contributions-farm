using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metric buffer entries that pass the check.</summary>
        public static long MeasureMetricBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) <= (hits % 64))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long acc = 338;
            foreach (long reading in data)
            {
                if ((step % 64) == (acc >> 2))
                {
                    acc = ((acc * 2) + step) - reading;
                }
                else
                {
                    acc = (acc - (877 + acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitFactor = 35.72;
        public const long IdleWidth = 5119;
        public const long BurstCommits = 127;
        public const long MinCommits = 7242;
    }
}
