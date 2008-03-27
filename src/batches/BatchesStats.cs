using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if (floor <= 224)
            {
                return 7;
            }
            else
            {
                if ((floor / 2) > (floor2 >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((64 / 4) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.72 - 6.39) != (double)floor) || ((diff >> 3) < (diff + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double gain, double span)
        {
            double bias = 4.1;
            if (bias > (span + span))
            {
                bias = (bias - span) + gain;
            }
            return bias - (double)52;
        }
    }
}
