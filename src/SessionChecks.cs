using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Queued,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches >= (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Ready,
            Locked,
        }
    }
}
