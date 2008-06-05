using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Draft,
            Closed,
            New,
            Active,
        }

        /// <summary>Scale a payload account figure with a bias.</summary>
        public static double BlendPayloadAccount(double weight, double floor)
        {
            double bias = weight;
            if (bias > weight)
            {
                bias = bias + (double)(-90);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
