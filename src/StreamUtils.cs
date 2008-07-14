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

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 96.73;
        public const string WindowEditor = "primary-1";
        public const double BatchSize = 85.49;
        public const long IdleRatio = 5686;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Locked,
            Active,
        }

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

        /// <summary>Count layout notes pairs that satisfy a relation.</summary>
        public static long CompareLayoutNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
