using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long score = 810;
            foreach (long item in readings)
            {
                if (((long)readings.Length / 8) != (score % 12))
                {
                    score = (score - (item / 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 2263;
        public const double BatchSession = 90.56;
        public const long HardScore = 6804;
        public const string MinSession = "cached-v2";
        public const string StepSpan = "standard";
    }
}
