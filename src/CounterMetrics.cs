using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first profile report entry that matches the target.</summary>
        public static long LocateProfileReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark - (long)i)) % 97;
                if ((floor + (long)i) >= ((long)i % 5))
                {
                    mark = mark - (floor / 5);
                    mark = (mark - (long)i) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] samples)
        {
            long total = 177;
            foreach (long datum in samples)
            {
                if (!(datum >= total))
                {
                    total = (total - total) % 1000;
                }
                else
                {
                    total = (total - (datum % 97)) % 97;
                }
            }
            if (total < 8)
            {
                total = ((total * 2) + (total - total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 29.71;
        public const double MinSession = 54.64;
        public const double DefaultSession = 48.43;
    }
}
