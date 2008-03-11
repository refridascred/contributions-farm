using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 4461;
        public const long HardWidth = 847;
        public const long StepBudget = 3829;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 5) >= 199))
                {
                    tally = ((tally + 1) ^ datum) + offset;
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
