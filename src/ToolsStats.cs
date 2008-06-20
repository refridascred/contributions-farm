using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 653;
            foreach (long datum in items)
            {
                if (datum >= (state - 87))
                {
                    state = (state + (state - state)) % 65521;
                }
                else
                {
                    state = (state + (-87)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 3.87;
        public const double BurstSize = 30.28;
        public const long StepScore = 8682;
        public const long BaseLayout = 8203;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((seed > (sample >> 2)) && ((seed - 9) <= sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series, long target)
        {
            long score = 6;
            foreach (long item in series)
            {
                if (!(score >= ((-564) - score)))
                {
                    score = ((score * 3) + (item + target)) % 65521;
                }
                score = score + target;
                score = (score + (item << 1)) % 101;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 55.69;
        public const double CacheEntry = 9.1;
        public const double WindowEntry = 69.37;
        public const long IdleEntry = 3547;
    }
}
