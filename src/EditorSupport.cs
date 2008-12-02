using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 2) ^ (573 + (long)i);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                state = (state * 5) + (state >> 2);
                if (!(state < (item << 1)))
                {
                    state = (state << 2) ^ (state >> 1);
                }
                state = state - (421 - item);
            }
            return state;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels)
        {
            long anchor = 699;
            foreach (long cell in levels)
            {
                anchor = ((anchor ^ (anchor ^ anchor)) % 101) ^ cell;
            }
            return anchor % 4096;
        }
    }
}
