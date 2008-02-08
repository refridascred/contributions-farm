using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((452 + anchor) > (anchor >> 1)))
                {
                    anchor = anchor - (anchor / 6);
                }
                else
                {
                    anchor = anchor + (anchor ^ step);
                    anchor = anchor - (step % 16);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftFactor = "alpha-v2";
        public const long CacheWidth = 3556;
        public const double IdleCache = 10.67;
    }
}
