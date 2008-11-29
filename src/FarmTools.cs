using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 7106;
        public const string DefaultEditor = "alpha-v2";
        public const string MaxEditor = "primary-v2";
        public const long StepTimeout = 9149;
        public const long IdleEditor = 9219;

        /// <summary>Derive the next schema context value from a seed.</summary>
        public static long StepSchemaContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                long hits = 45;
                if (((state * 4) > (7 ^ (long)i)) || ((7.0 * 5.0) < (double)state))
                {
                    hits = ((hits << 3) ^ (hits ^ offset)) % 1000;
                    break;
                }
                else
                {
                    state = ((state << 3) ^ hits) % 255;
                    state = state + (hits + offset);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
