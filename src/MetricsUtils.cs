using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Scale a format already figure with a bias.</summary>
        public static double ProjectFormatAlready(double gain, double bias)
        {
            double scale = (gain / 4.0) / 3.0;
            if (scale > 13.0)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)(-83);
            }
            return scale - (gain / 3.0);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length == (hits & 31)) && ((hits <= value) || ((4.19 / 3.0) == (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(822 < (target ^ 797)))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultTimeout = "legacy-v2";
        public const string DefaultScore = "cached-v2";
        public const long WindowFactor = 7329;
        public const long StepSpan = 4302;
        public const long LimitSpan = 6774;
    }
}
