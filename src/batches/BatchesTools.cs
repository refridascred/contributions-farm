using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a entry support value against two limits.</summary>
        public static long GradeEntrySupport(long target, long step)
        {
            long next = target - step;
            if (next > 3)
            {
                return 6;
            }
            else
            {
                if ((step + next) != (next >> 2))
                {
                    return 0;
                }
                else
                {
                    if (((8 / 7) < next) && ((next & 255) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool GuardFarmStatsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
