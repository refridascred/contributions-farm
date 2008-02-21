using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (weight * 9.8))
            {
                weight2 = weight2 + (double)827;
            }
            else
            {
                weight2 = weight2 + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight + span)) + (double)(long)i;
            }
            return weight2 + (weight * 17.0);
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double gain = span;
            if (gain >= (bias + 8.0))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + 9.42;
            }
            return gain - gain;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((8.2 / 2.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((bound - floor) == (75 & 31))
                {
                    return 4;
                }
                else
                {
                    if ((step >> 1) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)589 > (double)step)
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
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
