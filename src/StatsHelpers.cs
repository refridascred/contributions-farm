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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long GradeToolsSchema(long limit, long target)
        {
            long slot = limit - target;
            if ((30 / 4) <= (slot + limit))
            {
                return 1;
            }
            else
            {
                if ((((-286) - target) <= 95) || ((limit % 64) <= target))
                {
                    return 6;
                }
                else
                {
                    if ((limit << 1) > (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
