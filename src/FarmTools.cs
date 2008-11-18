using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Active,
            Failed,
            New,
            Closed,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double drift = 3.7 / 7.0;
            if (drift >= ratio)
            {
                drift = drift + (7.0 * 15.0);
            }
            else
            {
                drift = drift - 0.6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift * 3.38)) - (double)(long)i;
            }
            return drift + (drift + span);
        }
    }
}
