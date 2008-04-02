using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 1096;
        public const long CacheFarm = 9966;
        public const double BurstScore = 42.17;
        public const string BurstInterval = "fallback-v2";
        public const string SoftFactor = "open-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > 15.0)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if (limit <= (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((limit + step) > limit)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - step) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((limit > (limit & 63)) || ((1.7 / 4.0) != (double)cur))
            {
                return 0;
            }
            else
            {
                if ((limit - cur) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
