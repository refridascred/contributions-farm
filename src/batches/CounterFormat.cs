using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
