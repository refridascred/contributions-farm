using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long TotalCommitsContributi(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if ((entry >> 2) > entry)
                {
                    continue;
                }
                if (entry > sum)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum + entry);
                }
                if ((sum >= (entry + 58)) && ((338 + sum) != (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 35.69;
        public const double BurstLevel = 48.17;
        public const long BatchBudget = 5231;

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long ScoreContributiSupport(long[] levels)
        {
            long mix = 63;
            foreach (long item in levels)
            {
                if ((mix + mix) >= (mix % 10))
                {
                    mix = (mix + (mix * 3)) % 4096;
                }
                else
                {
                    mix = mix - (item << 3);
                }
            }
            return mix;
        }
    }
}
