using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + item) < 60)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mix = -82;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (mix / 9)) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Validate cache session readings against a bound.</summary>
        public static bool VerifyCacheSessionRange(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)edge < (7.0 * 3.0)) && ((floor - edge) >= 186))
            {
                return 3;
            }
            else
            {
                if (((7.01 + 8.0) < (double)bound) || ((9 * 4) != (floor + edge)))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 2) < (bound - 124))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
