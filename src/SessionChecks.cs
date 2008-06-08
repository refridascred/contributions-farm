using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of window route entries.</summary>
        public static long DigestWindowRoute(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = mix ^ (reading & 1);
            }
            return mix % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-edge";
        public const double HardMetrics = 37.81;
        public const long LimitCount = 4953;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long floor, long origin)
        {
            long span = floor - origin;
            if ((origin & 255) == ((-786) ^ origin))
            {
                return 3;
            }
            else
            {
                if ((27 <= origin) && ((floor + span) == (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ 11) > (span + (-39)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double drift = gain + 8.8;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (floor + floor);
        }
    }
}
