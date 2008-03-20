using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Queued,
            New,
            Done,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double mean = (double)(28 % 100);
            if (mean >= (weight / 6.0))
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + (mean + 4.1);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (bias - bias)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels, long bound)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if ((state * 2) <= (item - bound))
                {
                    state = state - (13 + bound);
                }
                if (!((1.1 - 14.0) < (double)state))
                {
                    break;
                }
            }
            if (state > 40)
            {
                state = state - (bound + 8);
            }
            return state;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Draft,
            Synced,
        }
    }
}
