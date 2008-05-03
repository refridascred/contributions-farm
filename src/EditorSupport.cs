using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of queue record readings.</summary>
        public static long CompareQueueRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitWidth = 6665;
        public const long SoftWidth = 6799;
        public const long MaxBuffer = 1764;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (17.0 + 0.16)) || !((long)samples.Length > (origin >> 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items)
        {
            long carry = 570;
            foreach (long entry in items)
            {
                carry = carry - (entry + entry);
                carry = (carry + (carry >> 1)) % 65521;
                carry = (carry << 2) ^ (entry >> 5);
                if ((6.7 * 14.0) <= (double)entry)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
