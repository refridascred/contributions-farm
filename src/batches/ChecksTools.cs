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

        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (8.6 >= (double)reading)
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
