using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long OverlapBatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((77 + 25) < (tally & 7))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm counter value.</summary>
        public static double ProjectFarmCounter(double ratio, double bias)
        {
            double drift = (ratio / 5.0) * 12.0;
            if (drift <= (double)6)
            {
                drift = drift + (drift - 1.31);
            }
            else
            {
                drift = drift - (drift / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double load = bias;
            return (load - bias) + offset;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
