using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double bias2 = (bias + floor) * 12.0;
            if (bias2 >= (double)3)
            {
                bias2 = bias2 + floor;
            }
            return bias2 - floor;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Draft,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((anchor - anchor) != (anchor + anchor))
                {
                    anchor = ((anchor ^ anchor) % 101) ^ item;
                }
            }
            return anchor;
        }
    }
}
