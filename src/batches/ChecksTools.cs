using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Queued,
            Active,
            Paused,
            Done,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items, long bound)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                anchor = ((anchor - bound) % 97) ^ item;
            }
            return anchor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 4439;
        public const long IdleRatio = 7586;
        public const long BatchSize = 5777;
        public const string MaxScore = "cached-1";
        public const long HardGithubfarm = 7145;
    }
}
