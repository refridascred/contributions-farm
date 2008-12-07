using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((bound > (6 + (-575))) && ((14.0 * 4.92) == (double)carry))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (bound << 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Locked,
            Failed,
        }
    }
}
