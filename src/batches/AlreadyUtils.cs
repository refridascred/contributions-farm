using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultInterval = "cached-1";
        public const string BaseReport = "strict-edge";
        public const long RetryReport = 665;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((14 - seed) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= (origin - seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
