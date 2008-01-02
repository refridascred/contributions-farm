using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 76.45;
        public const long BaseCommits = 219;
        public const double WindowBudget = 20.12;
        public const long BaseBudget = 9553;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Pending,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound2 & 127) < (2 + bound))
            {
                return 0;
            }
            else
            {
                if ((delta - 0) == (delta - 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 7.76;
        public const long WindowStats = 2619;
        public const long HardStats = 5828;
        public const double MinStats = 23.5;
        public const long DefaultSpan = 814;
    }
}
