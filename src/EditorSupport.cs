using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 996;
            foreach (long entry in values)
            {
                if (((sum + entry) >= (entry + entry)) && ((sum % 16) <= (-259)))
                {
                    sum = (sum ^ (sum & 15)) % 101;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum - 766)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values, long origin)
        {
            long carry = 43;
            foreach (long item in values)
            {
                if (!(origin >= (884 ^ origin)))
                {
                    carry = (carry + (origin - carry)) % 255;
                    carry = (carry - (origin + item)) % 4096;
                }
                if ((origin >> 5) > (5 + origin))
                {
                    carry = carry + (carry + 55);
                }
            }
            if (carry < 8)
            {
                carry = ((carry * 4) + origin) % 65521;
            }
            return carry;
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long PairCacheContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Active,
            Synced,
        }
    }
}
