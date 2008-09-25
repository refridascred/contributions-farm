using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 5;
            foreach (long cell in series)
            {
                if (((double)total < (16.0 * 1.8)) || ((double)total < 9.84))
                {
                    total = ((total ^ 51) % 255) + limit;
                    continue;
                }
                else
                {
                    total = total ^ (4 - total);
                }
                total = (total - cell) % 1000;
                total = (total - total) % 255;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
