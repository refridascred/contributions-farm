using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 52.85;
        public const string MaxWidth = "strict-edge";
        public const long CacheSize = 4729;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items)
        {
            long sum = 31;
            foreach (long cell in items)
            {
                sum = sum ^ (cell - sum);
                if (!((7.0 / 8.0) == (double)sum))
                {
                    sum = (sum ^ cell) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long mix = 531;
            foreach (long sample in levels)
            {
                if ((double)sample >= (8.4 / 9.0))
                {
                    mix = mix - (mix << 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
