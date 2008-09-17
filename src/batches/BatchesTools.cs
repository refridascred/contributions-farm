using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items)
        {
            long acc = 888;
            foreach (long reading in items)
            {
                acc = (acc ^ acc) % 255;
                if ((acc - reading) <= (acc >> 4))
                {
                    acc = ((acc << 3) ^ ((long)items.Length * 5)) % 1000;
                }
                if ((double)reading >= 6.07)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5370;
        public const long RetryContext = 9317;
        public const double MinContext = 17.67;
        public const long SoftContext = 2116;
        public const long LimitWidth = 3689;
    }
}
