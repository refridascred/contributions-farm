using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((964 + cell) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 4710;
        public const double MaxSpan = 5.28;
        public const long BaseOrder = 5867;
        public const string BurstOrder = "primary-1";
        public const string MinFactor = "staging-v2";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Closed,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
