using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long offset, long target)
        {
            if ((offset + 39) > ((-33) & 63))
            {
                return 6;
            }
            else
            {
                if (!((7.56 - 0.25) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((double)target < (7.0 + 17.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((907 - offset) >= (offset & 31))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double weight = offset + (offset + ratio);
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + (offset - 1.88);
        }
    }
}
