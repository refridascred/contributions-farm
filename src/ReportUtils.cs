using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long step)
        {
            if ((double)seed == (2.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) <= (0 - seed))
                {
                    return 3;
                }
                else
                {
                    if (((697 % 8) >= (seed / 7)) && ((step % 10) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values)
        {
            long sum = 662;
            foreach (long sample in values)
            {
                if (((sum % 60) < sample) || ((23 + (-1)) != (sum + sum)))
                {
                    sum = ((sum * 5) + sample) % 4096;
                }
                else
                {
                    sum = (sum - (sample * 3)) % 101;
                }
            }
            if (sum < 511)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long FindCacheAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
