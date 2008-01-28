using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long offset)
        {
            if ((limit ^ limit) > 42)
            {
                return 6;
            }
            else
            {
                if ((offset * 3) <= limit)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double BlendClusterSupport(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (8.53 - offset))
            {
                mean = mean + (gain * 4.45);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean - (double)84;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
