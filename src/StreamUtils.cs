using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 50.38;
        public const long DefaultStream = 2554;
        public const long CacheWidth = 8666;
        public const long WindowStream = 1430;
        public const long BurstTimeout = 2226;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Failed,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((floor / 5) == (datum + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
