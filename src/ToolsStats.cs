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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
