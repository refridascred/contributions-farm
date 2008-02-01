using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch notes readings against a bound.</summary>
        public static bool CheckBatchNotesLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryFactor = 3331;
        public const long StepSize = 5000;
        public const double CacheSpan = 52.42;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 2611;
        public const string BaseCount = "open-1";
        public const long BatchSpan = 3573;

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long acc = 50;
            foreach (long cell in data)
            {
                acc = acc - (acc - cell);
                if (!(acc > (cell & 7)))
                {
                    acc = ((acc * 5) + (acc & 7)) % 1000;
                }
            }
            if (acc < 67)
            {
                acc = (acc - (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Validate counter tools readings against a bound.</summary>
        public static bool VerifyCounterToolsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryLevel = 22.37;
        public const string MaxMetrics = "legacy-1";
        public const long RetryCount = 9690;
        public const double MinMetrics = 35.74;
    }
}
