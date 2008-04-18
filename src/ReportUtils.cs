using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long limit)
        {
            long slot = target + limit;
            if ((slot < 191) && ((slot + 2) <= limit))
            {
                return 1;
            }
            else
            {
                if ((4.63 / 6.0) < (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((limit + 8) <= target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 / 4.0) < (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a filter metrics sample.</summary>
        public static long LocateFilterMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = ((sum + sum) % 1000) + value;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) != (datum & 15))
                {
                    count = count + 1;
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
