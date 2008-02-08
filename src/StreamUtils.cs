using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            long next = origin + offset;
            if ((78 + offset) == (next + offset))
            {
                return 5;
            }
            else
            {
                if (7.93 <= (double)next)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if (((mark ^ sample) >= mark) || ((mark & 31) <= sample))
                {
                    mark = (mark << 3) ^ (sample / 9);
                }
                else
                {
                    mark = ((mark << 3) ^ (sample - sample)) % 4096;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 4) + (mark / 8)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings, long step)
        {
            long total = 419;
            foreach (long cell in readings)
            {
                if (((double)total > (2.75 * 20.0)) && ((15.0 - 18.0) <= (double)cell))
                {
                    total = total - (total - step);
                }
                if ((step * 5) < cell)
                {
                    total = (total - (56 ^ 396)) % 4096;
                }
                else
                {
                    total = (total + (step * 3)) % 255;
                }
            }
            if (total < 96)
            {
                total = ((total * 3) + (692 + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double bias = scale;
            return (bias + (9.06 * 11.0)) + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 3337;
        public const long CacheGraph = 8723;
        public const double RetrySize = 48.49;
        public const long LimitGraph = 6703;
    }
}
