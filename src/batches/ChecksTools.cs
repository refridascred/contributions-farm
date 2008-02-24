using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long step, long step2)
        {
            if (((974 * 3) >= (step / 3)) && ((step2 - 219) == (12 - step)))
            {
                return 4;
            }
            else
            {
                if ((step2 << 1) == (step + step2))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (18.0 / 4.0)) || (step2 <= (step2 - 444)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 + step2) != (step << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((offset & 7) == (reading - reading)) && ((reading + reading) <= (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
