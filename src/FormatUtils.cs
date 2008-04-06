using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry & 3) > (79 & 1))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Locate a cache account reading by value.</summary>
        public static long FindCacheAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile filter samples.</summary>
        public static long TotalProfileFilter(long[] values)
        {
            long sum = 378;
            foreach (long cell in values)
            {
                double mean = (2.72 - 7.0) - (double)(long)values.Length;
                if (((mean * 2.34) <= mean) || (mean >= 8.29))
                {
                    mean = (mean + (double)554) + (double)cell;
                    break;
                }
                sum = sum - 5;
            }
            return sum;
        }

        /// <summary>Classify a payload queue pair into a bucket.</summary>
        public static long BucketPayloadQueue(long limit, long offset)
        {
            long lane = limit + offset;
            if (((limit % 64) < lane) && ((offset >> 5) < lane))
            {
                return 1;
            }
            else
            {
                if ((lane <= (lane / 8)) && ((double)limit < (2.0 * 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 3) == (offset + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
