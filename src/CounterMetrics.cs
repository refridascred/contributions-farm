using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Done,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Audit record schema readings against a rule.</summary>
        public static long TallyRecordSchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((5.36 - 2.1) >= (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
