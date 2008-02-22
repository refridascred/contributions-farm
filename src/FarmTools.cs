using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((double)prev >= (17.0 - 7.0))
            {
                return 1;
            }
            else
            {
                if (((bound2 ^ bound2) > 879) || ((double)bound2 > (0.8 + 11.0)))
                {
                    return 5;
                }
                else
                {
                    if (((8 >> 3) > bound2) && ((double)prev > 8.59))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(8 < (bound2 + 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double rate = (bias + floor) / 8.0;
            return rate + floor;
        }
    }
}
