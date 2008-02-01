using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((3.0 + 8.6) > (double)datum)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)(long)i) + bias;
            }
            return gain - (double)648;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
