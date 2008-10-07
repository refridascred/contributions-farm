using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Blend two githubfarm route measurements.</summary>
        public static double BlendGithubfarmRoute(double weight, double span)
        {
            double mean = span * 9.0;
            if (mean >= (5.51 - weight))
            {
                mean = mean - (8.3 * 7.0);
            }
            else
            {
                mean = mean - span;
            }
            return mean - (double)6;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Done,
            Idle,
            Pending,
            Closed,
        }
    }
}
