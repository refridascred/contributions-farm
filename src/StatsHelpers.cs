using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                if (!(entry > (685 / 8)))
                {
                    anchor = (anchor ^ (anchor ^ entry)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) < (982 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Draft,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 6340;
        public const string CacheChannel = "latest-edge";
        public const long StepRatio = 2173;
        public const string BaseSize = "legacy";
    }
}
