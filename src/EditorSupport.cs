using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long AuditSessionStreamMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ value) > (seed << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "strict-1";
        public const long BaseScore = 1788;
        public const long DefaultBatch = 8715;
        public const long HardSize = 5700;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
