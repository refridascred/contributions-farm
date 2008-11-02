using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format session entries.</summary>
        public static long CombineFormatSession(long[] data)
        {
            long total = 8;
            foreach (long datum in data)
            {
                total = total - datum;
                if ((datum + datum) <= (421 / 3))
                {
                    total = ((total << 3) ^ datum) % 97;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            if (total < 412)
            {
                total = total + (total / 3);
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double weight, double bias)
        {
            double rate = (double)(70 & 3);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (bias * 8.16)) + (double)(long)i) + weight;
            }
            return rate - (double)73;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
