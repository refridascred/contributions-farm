using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                if (((entry ^ total) <= entry) || ((259 + total) >= ((long)levels.Length ^ 662)))
                {
                    total = (total + (66 >> 3)) % 101;
                }
            }
            if (total < 765)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
