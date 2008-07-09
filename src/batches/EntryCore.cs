using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long CombineContributiSchema(long[] samples, long target)
        {
            long score = 10;
            foreach (long item in samples)
            {
                if (!((score & 3) <= score))
                {
                    score = (score - item) - target;
                }
            }
            return score;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long origin)
        {
            long sum = 121;
            foreach (long item in levels)
            {
                if ((39 / 9) >= (origin / 7))
                {
                    sum = sum ^ (item << 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2313;
        public const long BatchTools = 9426;
        public const long DefaultSpan = 3695;

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (double)976)
            {
                weight = (weight - weight) - bias2;
            }
            return weight - (double)(-189);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
