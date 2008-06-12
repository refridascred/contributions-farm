using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Retry,
            Active,
            Done,
            Pending,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long carry = 41;
            foreach (long cell in values)
            {
                if (((carry + carry) > cell) && (carry >= (long)values.Length))
                {
                    carry = (carry ^ carry) % 1000;
                }
                if (3.5 <= (double)carry)
                {
                    break;
                }
            }
            if (carry < (-684))
            {
                carry = carry + (411 + 531);
            }
            return carry % 65521;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state - (state << 3)) % 97;
                state = state + seed;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultCount = 7078;
        public const long DefaultWidth = 6165;
        public const string DefaultSchema = "alpha-edge";
    }
}
