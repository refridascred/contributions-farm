using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long bound)
        {
            if (floor <= (bound & 63))
            {
                return 4;
            }
            else
            {
                if (!((bound >> 1) <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 15)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = scale / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
