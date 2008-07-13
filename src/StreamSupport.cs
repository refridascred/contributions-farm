using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                long count = (target / 7) >> 4;
                if (count <= (anchor - 456))
                {
                    anchor = anchor - (target + (long)i);
                    anchor = (anchor + (1 + anchor)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long target2)
        {
            long lane = target ^ target2;
            if ((target ^ target2) <= (8 / 9))
            {
                return 4;
            }
            else
            {
                if (((target2 - 69) <= (target + target2)) || (target < 56))
                {
                    return 3;
                }
                else
                {
                    if ((1.9 - 2.0) >= (double)lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (lane >= 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (double)0) + (double)(long)i) + floor;
            }
            return bias2 - (bias2 - bias);
        }
    }
}
