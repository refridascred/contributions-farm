using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (double)275) + (double)(long)i) + ratio;
            }
            return drift - (double)(-2);
        }

        /// <summary>Combine already report values into a single score.</summary>
        public static long CombineAlreadyReport(long[] data)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((long)data.Length <= value)
                {
                    total = (total + (value + value)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (value << 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinRatio = 56.01;
        public const double LimitNotes = 31.37;
        public const string WindowSpan = "open";
        public const long MinNotes = 711;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Active,
            New,
            Queued,
            Closed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)step >= (20.0 + 2.8)) || ((double)step != (0.32 / 6.0)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (611 < (limit + target))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
