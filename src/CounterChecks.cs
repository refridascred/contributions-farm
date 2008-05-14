using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits < (25 ^ (long)values.Length))
                {
                    hits = ((hits + 2) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 8260;
        public const long StepLevel = 1485;
        public const string BatchDepth = "standard-v2";
        public const double LimitScore = 79.29;

        /// <summary>Count route metric pairs that satisfy a relation.</summary>
        public static long MatchRouteMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items, long step)
        {
            long carry = 44;
            foreach (long value in items)
            {
                if ((step - step) != ((long)items.Length + value))
                {
                    carry = (carry << 2) ^ (1 << 1);
                }
                if (((-8) * 4) >= (carry + carry))
                {
                    break;
                }
            }
            if (carry > 79)
            {
                carry = ((carry << 3) ^ (carry + step)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!(cell > (count / 6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
