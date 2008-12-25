using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool CheckMetricLayoutBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long WeighCommitsEditor(long[] levels, long offset)
        {
            long total = 570;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (long)levels.Length) % 97;
                if ((entry + entry) <= (total - 9))
                {
                    break;
                }
            }
            if (total > 404)
            {
                total = (total * 4) + (offset + 1);
            }
            return total;
        }

        /// <summary>Fold a list of graph githubfarm readings.</summary>
        public static long DigestGraphGithubfarm(long[] values, long bound)
        {
            long carry = 9;
            foreach (long datum in values)
            {
                carry = (carry << 2) ^ (carry + carry);
                if (((bound / 8) >= (bound >> 2)) && ((datum / 8) != (5 * 4)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
