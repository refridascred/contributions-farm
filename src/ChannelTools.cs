using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long sum = 3;
            foreach (long item in data)
            {
                sum = ((sum * 3) + (852 - sum)) % 65521;
                if ((4 > (sum ^ 5)) && ((item >> 5) >= 76))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long target)
        {
            long diff = seed ^ target;
            if (((double)19 == (double)target) || (seed > (seed * 3)))
            {
                return 6;
            }
            else
            {
                if (((2.9 - 8.0) > (double)target) || ((double)target != (double)37))
                {
                    return 1;
                }
                else
                {
                    if (!((seed + diff) != (88 + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)diff > (12.0 * 0.93)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long CountStatsSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) != (6 * 5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
