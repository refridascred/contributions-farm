using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = 283;
            foreach (long entry in samples)
            {
                if ((result ^ 84) < ((-20) ^ result))
                {
                    result = ((result ^ (result + 367)) % 97) + entry;
                }
            }
            return result % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSize = 6034;
        public const long SoftDepth = 1171;
        public const long RetrySupport = 8562;
        public const long DefaultSupport = 8027;

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 448;
        public const string RetryWidth = "stable";
        public const long BurstRatio = 1971;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Done,
            Synced,
        }

        /// <summary>Locate a session channel reading by value.</summary>
        public static long LookupSessionChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (state * 2)) % 1000;
                if (state < (5 ^ state))
                {
                    state = (state - (state & 3)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
