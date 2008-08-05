using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((double)limit2 != (double)721)
            {
                return 4;
            }
            else
            {
                if (((2 & 63) <= (limit + limit)) && ((limit % 2) != (limit2 << 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit2 <= (9.7 * 4.61)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings, long seed)
        {
            long sum = 31;
            foreach (long entry in readings)
            {
                sum = ((sum + seed) % 4096) ^ entry;
            }
            return sum;
        }

        /// <summary>Adjust a farm metrics reading.</summary>
        public static double AdjustFarmMetrics(double scale, double span)
        {
            double load = (double)(8 - 7);
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale + span)) + (double)(long)i;
            }
            return load - (span - 15.0);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items, long limit)
        {
            long result = 995;
            foreach (long item in items)
            {
                if ((20.0 - 5.8) <= (double)item)
                {
                    result = ((result ^ item) % 97) - limit;
                }
            }
            if (result > 662)
            {
                result = (result + (5 & 255)) % 97;
            }
            return result;
        }
    }
}
