using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4261;
        public const string BatchFormat = "fallback-edge";
        public const long DefaultFactor = 1344;
        public const long StepBudget = 9349;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long value in levels)
            {
                if ((0.14 - 2.09) > (double)value)
                {
                    acc = ((acc * 3) + 8) % 1000;
                }
                if (value <= (84 + value))
                {
                    acc = (acc ^ (acc - acc)) % 97;
                }
            }
            if (acc < 3)
            {
                acc = (acc << 2) ^ (acc - origin);
            }
            return acc;
        }

        /// <summary>Match up buffer commits samples.</summary>
        public static long MatchBufferCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double ratio2 = span;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (6.85 * 4.9)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
