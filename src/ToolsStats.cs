using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
            Queued,
            Active,
        }

        /// <summary>Accumulate commits context samples.</summary>
        public static long DigestCommitsContext(long[] readings)
        {
            long score = 881;
            foreach (long datum in readings)
            {
                score = (score << 3) ^ (954 >> 3);
                score = score - (score + datum);
                score = score - datum;
            }
            if (score < 8)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseLevel = 4663;
        public const long MinWidth = 3110;
        public const long StepSpan = 1174;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 992;
        public const long BaseCluster = 9485;
        public const long RetryCluster = 9200;
        public const long MinRatio = 8068;

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardInterval = "legacy-1";
        public const long LimitScore = 7557;
        public const long BaseEditor = 3242;
        public const long WindowSize = 5986;
        public const double LimitEditor = 0.27;

        /// <summary>Audit stream command readings against a rule.</summary>
        public static long MeasureStreamCommandMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length ^ 97) >= (offset + reading)) && (hits > (offset << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
