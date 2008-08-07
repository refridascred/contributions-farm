using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepLevel = 4070;
        public const double BurstWidth = 42.6;
        public const long MaxCounter = 4189;
        public const string RetryCounter = "staging";
        public const double HardFactor = 81.47;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((-52) < (carry + carry)) && ((carry + seed) == (carry - 1)))
                {
                    carry = ((carry * 2) + 7) % 97;
                }
                carry = (carry - (carry ^ (long)i)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((seen < (datum ^ (-73))) || ((220 + 231) == (seen >> 4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Paused,
            Idle,
            Stale,
            Closed,
        }
    }
}
