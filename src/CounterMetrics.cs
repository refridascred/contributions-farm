using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Audit editor account readings against a rule.</summary>
        public static long CountEditorAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((463 + sample) >= ((long)samples.Length ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Active,
            Draft,
            Idle,
        }
    }
}
