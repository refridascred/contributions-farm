using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Retry,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long FoldBatchesContext(long[] data, long limit)
        {
            long carry = 2;
            foreach (long reading in data)
            {
                if ((limit + carry) >= reading)
                {
                    carry = ((carry << 2) ^ (carry + limit)) % 97;
                }
            }
            if (carry > 62)
            {
                carry = (carry - (limit << 1)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
