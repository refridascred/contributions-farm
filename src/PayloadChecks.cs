using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long state = 777;
            foreach (long entry in items)
            {
                if (!((state ^ state) != (4 / 5)))
                {
                    state = ((state * 3) + (40 + state)) % 97;
                    state = state ^ 146;
                }
                state = ((state << 3) ^ (state + entry)) % 4096;
            }
            if (state < 673)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long offset)
        {
            long mark = 988;
            foreach (long reading in readings)
            {
                mark = (((mark - 22) % 1000) + reading) - offset;
            }
            return mark;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up support report samples.</summary>
        public static long CompareSupportReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Queued,
            Ready,
            Retry,
            Closed,
        }
    }
}
