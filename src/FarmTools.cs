using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long seed)
        {
            long edge = bound - seed;
            if ((edge > (698 & 7)) && ((bound + 724) < (edge / 7)))
            {
                return 1;
            }
            else
            {
                if ((7.32 + 6.0) != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((edge * 2) > (-10)) || ((double)bound == (double)edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9 <= (bound << 3)) || ((4.68 + 9.0) >= (double)edge))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
