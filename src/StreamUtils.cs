using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long CombineCommandFarm(long[] values, long bound)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                mix = ((mix * 2) + reading) + bound;
            }
            if (mix > 782)
            {
                mix = mix - (728 / 6);
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 36.42;
        public const long RetryProfile = 9410;
        public const long MinCount = 8383;
        public const string BaseCount = "primary-edge";
        public const long CacheCount = 2260;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 12) == ((long)series.Length - floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Draft,
            Synced,
            Queued,
        }
    }
}
