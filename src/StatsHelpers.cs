using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > bound)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many entry cluster samples are out of range.</summary>
        public static long CountEntryClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value - 963) >= (count / 4)) && (((long)series.Length + value) <= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
