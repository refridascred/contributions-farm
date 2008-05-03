using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if ((origin % 16) == (bound - 4))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (4.0 * 4.4))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two stream window measurements.</summary>
        public static double ScaleStreamWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean > 18.0)
            {
                mean = (mean + (offset + 9.4)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
