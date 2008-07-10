using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = -17;
            foreach (long entry in samples)
            {
                state = ((state ^ (bound + bound)) % 255) - entry;
                state = (state << 3) ^ (4 + bound);
                state = ((state << 2) ^ (777 + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of report token entries.</summary>
        public static long DigestReportToken(long[] values, long seed)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if ((seed + 520) < (acc >> 1))
                {
                    acc = ((acc << 2) ^ (datum >> 4)) % 97;
                }
                if ((94 + datum) <= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 2405;
        public const string StepCount = "alpha-edge";
        public const long SoftEditor = 1402;
        public const string RetryCount = "stable-1";
        public const long StepBudget = 1960;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
