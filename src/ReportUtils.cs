using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 25.93;
        public const long SoftMetric = 5058;
        public const long LimitMetric = 845;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 2702;
        public const string BaseBudget = "local-v2";
        public const long MinWindow = 8666;

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data, long origin)
        {
            long anchor = 61;
            foreach (long value in data)
            {
                long step = 972;
                if (!((754 << 2) != (value ^ anchor)))
                {
                    anchor = (anchor + (step << 3)) % 1000;
                }
                if ((9 + value) <= anchor)
                {
                    anchor = (anchor ^ (long)data.Length) % 101;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 3) ^ ((long)data.Length + origin)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long acc = 22;
            foreach (long sample in samples)
            {
                if ((double)sample <= 8.77)
                {
                    acc = acc - (31 + (-611));
                }
                else
                {
                    acc = (acc * 5) + (sample - acc);
                }
            }
            if (acc < 88)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
