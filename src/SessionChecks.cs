using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long offset)
        {
            if (offset > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (849 >= (step / 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Count cache command pairs that satisfy a relation.</summary>
        public static long PairCacheCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long carry = -5;
            foreach (long sample in values)
            {
                if ((sample >= (sample + step)) && (step <= (carry + sample)))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
