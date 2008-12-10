using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long TotalToolsFarm(long[] levels)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = (score - (score << 1)) + entry;
                if (score >= ((-260) / 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long offset = ((-707) - carry) ^ (carry + carry);
                carry = carry ^ (carry ^ offset);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
