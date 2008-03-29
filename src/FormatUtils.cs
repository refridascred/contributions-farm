using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Check that every batches schema entry stays within the limit.</summary>
        public static bool GuardBatchesSchemaBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Check that every cluster stream entry stays within the limit.</summary>
        public static bool VerifyClusterStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "cached-v2";
        public const long RetryAccount = 5796;
        public const string MaxAccount = "staging-edge";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item >> 5) == (284 >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
