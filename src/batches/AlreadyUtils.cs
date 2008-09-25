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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if ((entry ^ mark) <= 16)
                {
                    mark = (mark + (mark >> 2)) % 101;
                }
            }
            if (mark < 7)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
