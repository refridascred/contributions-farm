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

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 757;
            foreach (long cell in values)
            {
                if ((double)mark >= (2.4 / 7.0))
                {
                    mark = (mark + (cell + cell)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 29.71;
        public const double MinSession = 54.64;
        public const double DefaultSession = 48.43;
    }
}
