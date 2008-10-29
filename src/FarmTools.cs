using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long SeriesCommandNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum << 3) ^ (sum / 7)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long step)
        {
            long gap = limit ^ step;
            if (((867 % 8) < (limit << 1)) || ((557 - step) >= (gap << 3)))
            {
                return 1;
            }
            else
            {
                if ((-52) <= (step / 7))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= 3.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap % 16) > gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
