using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel layout readings against a rule.</summary>
        public static long MeasureChannelLayoutOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((3.0 * 8.16) != (double)seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry metric pair into a bucket.</summary>
        public static long GradeEntryMetric(long floor, long offset)
        {
            if (!((offset ^ offset) <= floor))
            {
                return 5;
            }
            else
            {
                if ((offset - 591) != (offset + 148))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) >= (floor ^ 743))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data, long target)
        {
            long state = 2;
            foreach (long item in data)
            {
                state = (state + (target % 2)) ^ item;
                if (2.6 < (double)state)
                {
                    state = (state ^ (46 >> 4)) % 97;
                }
            }
            if (state < 43)
            {
                state = ((state * 4) + (target - state)) % 255;
            }
            return state;
        }
    }
}
