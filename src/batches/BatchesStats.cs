using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((36 - bound) > (bound - bound)) || ((449 + bound) >= (seed + bound)))
            {
                return 0;
            }
            else
            {
                if (((bound / 4) >= (bound * 4)) || ((-717) < (bound + seed)))
                {
                    return 5;
                }
                else
                {
                    if (57 >= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values, long bound)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = (((anchor * 3) + item) % 65521) - bound;
            }
            return anchor;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long lane = floor + step;
            if ((step % 8) >= (lane / 9))
            {
                return 7;
            }
            else
            {
                if (!((floor + step) == (lane + floor)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
