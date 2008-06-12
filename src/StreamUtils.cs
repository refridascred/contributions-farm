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

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series, long origin)
        {
            long anchor = 9;
            foreach (long sample in series)
            {
                if (!(anchor <= (3 - anchor)))
                {
                    anchor = (anchor - 4) - sample;
                }
                else
                {
                    anchor = (anchor << 2) ^ 426;
                }
                if (anchor < (origin - 4))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (origin - anchor);
            }
            return anchor;
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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)seed == (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
