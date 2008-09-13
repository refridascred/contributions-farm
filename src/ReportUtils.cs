using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 > (gain - gain))
            {
                gain2 = gain2 - 9.6;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 + (offset + 16.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long result = 6;
            foreach (long reading in items)
            {
                result = result ^ (reading % 8);
                if (9.2 <= (double)reading)
                {
                    result = ((result * 4) + (result + result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (reading << 2)) % 4096;
                }
            }
            if (result > 387)
            {
                result = ((result << 3) ^ (87 * 5)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
