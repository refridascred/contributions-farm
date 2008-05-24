using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank entry context input into a small class.</summary>
        public static long RankEntryContext(long bound, long offset)
        {
            if (((-8) + bound) < offset)
            {
                return 1;
            }
            else
            {
                if (((offset % 5) > (bound + (-316))) || ((bound << 2) < (bound + 11)))
                {
                    return 7;
                }
                else
                {
                    if (((9 + bound) <= bound) || (bound <= (offset / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.66 * 5.5) > (double)offset) && ((bound / 8) <= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
