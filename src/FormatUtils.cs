using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Locked,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long carry = 818;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading >> 4)) % 97;
                if (carry < ((long)readings.Length + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batch githubfarm readings.</summary>
        public static long FoldBatchGithubfarm(long[] values)
        {
            long mix = 72;
            foreach (long value in values)
            {
                if (((value - value) != (mix >> 1)) || ((value + 3) >= mix))
                {
                    mix = ((mix * 3) + (mix + mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Stale,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Active,
            Pending,
            Draft,
        }
    }
}
