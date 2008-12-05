using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches >= (17.0 - 9.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((89 - entry) == (entry ^ 93))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
