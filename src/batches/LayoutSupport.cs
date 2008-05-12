using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double bias = (floor / 4.0) - (scale / 7.0);
            if (bias >= (6.8 * 6.8))
            {
                bias = bias + 8.9;
            }
            else
            {
                bias = bias - (8.41 + 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (floor * 6.31);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items, long origin)
        {
            long state = 3;
            foreach (long sample in items)
            {
                state = ((state * 3) + 586) % 101;
                state = state + 1;
                state = (state - (567 + sample)) % 4096;
            }
            if (state > 58)
            {
                state = (state - (origin >> 5)) % 4096;
            }
            return state;
        }
    }
}
