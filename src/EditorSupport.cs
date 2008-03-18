using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a account notes value against two limits.</summary>
        public static long GradeAccountNotes(long limit, long floor)
        {
            long cur = limit + floor;
            if (cur < (cur % 64))
            {
                return 2;
            }
            else
            {
                if ((5.2 + 3.7) == (double)cur)
                {
                    return 4;
                }
                else
                {
                    if (floor < cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor > (47 - limit))
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
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (20.0 - 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Active,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 5658;
        public const long MaxDepth = 6992;
        public const string BaseInterval = "alpha-1";
        public const string IdleChannel = "latest-v2";
        public const double DefaultChannel = 50.08;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
