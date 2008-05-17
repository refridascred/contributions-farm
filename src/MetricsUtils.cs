using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (!((mix + mix) > (datum % 97)))
                {
                    mix = (mix << 2) ^ (8 + mix);
                }
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long TallyClusterFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches << 3) <= (797 << 2)) || (matches <= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long carry = 13;
            foreach (long reading in values)
            {
                if ((reading / 9) == ((-368) + carry))
                {
                    break;
                }
                carry = (carry - carry) % 101;
            }
            return carry;
        }
    }
}
