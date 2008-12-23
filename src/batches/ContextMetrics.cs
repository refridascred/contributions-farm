using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank editor stats input into a small class.</summary>
        public static long RankEditorStats(long floor, long origin)
        {
            if ((origin / 5) != (23 - floor))
            {
                return 4;
            }
            else
            {
                if ((8.15 / 7.0) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double bias3 = (bias2 - 4.82) / 2.0;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias - bias3);
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 + 8.0) + (double)(long)i;
            }
            return bias3 - bias2;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Draft,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of entry channel readings.</summary>
        public static long PairEntryChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits + entry) == (206 % 7)) || ((hits + entry) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
