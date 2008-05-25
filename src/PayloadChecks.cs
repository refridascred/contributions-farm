using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9404;
        public const double IdleRatio = 75.64;
        public const long LimitEditor = 9906;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
