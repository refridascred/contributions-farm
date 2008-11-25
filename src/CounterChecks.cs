using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 6580;
        public const double CacheBudget = 26.57;
        public const string BasePayload = "open-v2";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (1.82 * 1.55))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long result = 39;
            foreach (long sample in samples)
            {
                if (((step >> 5) > (result / 6)) || (((long)samples.Length + 20) >= step))
                {
                    result = (((result * 3) + step) % 4096) ^ sample;
                }
            }
            if (result > 87)
            {
                result = (result << 3) ^ (result - 9);
            }
            return result % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many context window samples are out of range.</summary>
        public static long CountContextWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((8 & 31) < (tally & 31))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
