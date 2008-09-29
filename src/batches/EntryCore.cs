using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a githubfarm contributi reading by value.</summary>
        public static long LocateGithubfarmContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen ^ sample) >= (sample >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 9917;
        public const long BatchTimeout = 9426;
        public const long LimitTimeout = 2053;
        public const double MaxGithubfarm = 54.97;
        public const long RetryInterval = 6633;

        /// <summary>Define command limits and defaults.</summary>
        public const long MinLevel = 7910;
        public const long MinCommand = 8339;
        public const long LimitLevel = 1594;
        public const string StepCommand = "legacy";
    }
}
