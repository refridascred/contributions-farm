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

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long diff = origin + target;
            if ((2.2 * 4.0) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target % 24) == (209 & 15))
                {
                    return 7;
                }
                else
                {
                    if ((target + origin) == (diff * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (11.0 + 8.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
