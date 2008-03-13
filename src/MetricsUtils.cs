using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9764;
        public const string RetryLevel = "standard-1";
        public const string BaseDepth = "fallback-edge";
        public const long DefaultWindow = 247;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long bound)
        {
            long score = 90;
            foreach (long entry in items)
            {
                score = (((score << 2) ^ 588) - entry) - bound;
            }
            return score;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((long)data.Length - (-729)) != (cell - matches)))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
