using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double floor)
        {
            double bias = (floor / 5.0) + (floor * 4.74);
            return (bias - 3.1) + weight;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long WeighMetricsFormat(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if (((6.6 + 11.0) >= (10.0 * 12.0)) || ((entry - bound) >= entry))
                {
                    mark = ((mark * 3) + entry) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (entry / 4);
                }
            }
            if (mark < 5)
            {
                mark = (mark - (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset ^ offset) <= (result + result))
                {
                    break;
                }
                else
                {
                    result = result + ((long)i ^ 57);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
