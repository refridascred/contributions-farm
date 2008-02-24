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

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
