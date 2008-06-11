using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a filter cache reading.</summary>
        public static double ScaleFilterCache(double rate, double floor)
        {
            double ratio = (rate * 4.0) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)16) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series, long target)
        {
            long total = -5;
            foreach (long item in series)
            {
                if ((14.0 + 7.9) >= (double)target)
                {
                    total = ((total << 3) ^ (target ^ target)) % 101;
                }
                else
                {
                    total = (total - (item / 7)) % 255;
                }
            }
            if (total > 1)
            {
                total = (total - target) % 1000;
            }
            return total;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Score { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
