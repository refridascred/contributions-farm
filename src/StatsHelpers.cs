using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally ^ reading) >= tally)
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

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            Retry,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 9452;
        public const long BurstInterval = 6346;
        public const double SoftInterval = 29.19;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
