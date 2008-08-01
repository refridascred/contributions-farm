using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Synced,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit - score) == (score - score))
                {
                    score = (score ^ (score % 97)) % 97;
                    score = score ^ (limit ^ limit);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "fallback-v2";
        public const long IdleSession = 5659;
        public const long LimitFactor = 569;
        public const long HardFactor = 9615;
        public const long BatchLevel = 6883;
    }
}
