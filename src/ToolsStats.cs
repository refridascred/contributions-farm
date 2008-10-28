using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of context channel readings.</summary>
        public static long WeighContextChannel(long[] data)
        {
            long acc = 86;
            foreach (long item in data)
            {
                acc = (acc - (1 - acc)) + item;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long FindFarmAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool VerifyWindowGithubfarmRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long total = 377;
            foreach (long reading in readings)
            {
                if ((total << 1) != (reading - 9))
                {
                    total = ((total ^ (reading / 7)) % 255) + origin;
                }
            }
            if (total < 7)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)count >= (double)datum) || ((double)datum < (12.0 * 4.7)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
