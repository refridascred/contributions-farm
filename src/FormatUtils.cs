using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Digest a series of support layout entries.</summary>
        public static long TotalSupportLayout(long[] readings)
        {
            long state = 924;
            foreach (long reading in readings)
            {
                if (state > (reading << 3))
                {
                    state = (state << 2) ^ 6;
                }
                else
                {
                    state = (state + (state % 24)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item ^ tally) > (tally - (long)samples.Length))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 7441;
        public const string BatchGithubfarm = "primary-v2";
        public const long StepGithubfarm = 640;
        public const long SoftLevel = 3059;

        /// <summary>Locate a session metric reading by value.</summary>
        public static long LookupSessionMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
