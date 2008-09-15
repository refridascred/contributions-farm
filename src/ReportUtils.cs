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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Count { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 3) ^ carry) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
