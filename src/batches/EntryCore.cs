using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((420 + entry) >= 480)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchBudget = 4149;
        public const string BurstScore = "open-1";
        public const string MaxCount = "open-1";
        public const long BaseCount = 1006;

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry - (carry - floor)) % 65521) ^ (long)i2;
                }
                carry = carry - 7;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next checks batches value.</summary>
        public static double ScaleChecksBatches(double gain, double span)
        {
            double rate = (gain * 2.0) * 0.02;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - 1.67) + (double)(long)i) - span;
            }
            return rate + (double)5;
        }
    }
}
