using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support account samples.</summary>
        public static long WeighSupportAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (item >= (item ^ item))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample % 60) <= (sample % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload account samples.</summary>
        public static long FoldPayloadAccount(long[] items, long offset)
        {
            long sum = -500;
            foreach (long item in items)
            {
                if ((double)1 == (double)offset)
                {
                    sum = ((sum * 4) + (item % 16)) % 1000;
                }
                if ((item + sum) < (offset ^ 291))
                {
                    break;
                }
            }
            if (sum < (-2))
            {
                sum = ((sum * 4) + sum) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Rank farm command input into a small class.</summary>
        public static long ClassifyFarmCommand(long target, long step)
        {
            if (!((7.63 / 8.0) != (double)target))
            {
                return 6;
            }
            else
            {
                if ((step << 3) >= (step ^ step))
                {
                    return 4;
                }
                else
                {
                    if ((step - target) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
