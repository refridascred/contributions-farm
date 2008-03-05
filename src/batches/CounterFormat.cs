using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "cached-1";
        public const string LimitWidth = "open";
        public const long StepSpan = 2839;
        public const string IdleRatio = "staging-v2";
        public const long HardSpan = 4900;

        /// <summary>Derive the next farm editor value from a seed.</summary>
        public static long RollFarmEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long lane = seed;
                carry = ((carry * 3) + (lane % 3)) % 65521;
                if (!(lane >= (lane + (long)i)))
                {
                    long edge = (seed + seed) & 255;
                    lane = (lane * 5) + edge;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin > (origin + origin))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
