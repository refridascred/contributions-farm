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

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowInterval = "strict-1";
        public const string HardBatch = "staging";
        public const long StepBatch = 6329;
        public const double MinBatch = 90.33;

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
