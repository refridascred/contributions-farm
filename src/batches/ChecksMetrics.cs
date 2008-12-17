using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats checks readings against a bound.</summary>
        public static bool VerifyStatsChecksRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of metrics stream readings.</summary>
        public static long MatchMetricsStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultLevel = "standard-1";
        public const long BatchCommits = 5835;
        public const long DefaultCommits = 9894;
    }
}
