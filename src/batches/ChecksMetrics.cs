using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long IterateEditorTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state - (state + origin)) % 1000;
                if (((state << 1) != (origin - (long)i)) && ((double)origin < 14.0))
                {
                    state = state + (origin + state);
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double bias2 = (double)(7 << 3);
            if (bias2 >= (offset * 9.09))
            {
                bias2 = bias2 - 4.4;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + (bias * 7.0);
        }
    }
}
