using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Stale,
            Closed,
            New,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 6098;
        public const double HardSize = 63.04;
        public const long MinWidth = 4118;
        public const double IdleDepth = 12.5;
    }
}
