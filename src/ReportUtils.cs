using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinInterval = "strict";
        public const double BatchBuffer = 52.21;
        public const string BurstBudget = "local-1";

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long total = 25;
            foreach (long item in values)
            {
                if ((double)total >= (8.9 / 5.0))
                {
                    total = (((total << 3) ^ item) % 101) + limit;
                }
                else
                {
                    total = (total * 5) + (total * 3);
                }
            }
            return total;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin > (anchor ^ anchor)) && (anchor < (origin << 1)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if (((origin + origin) >= origin) && (6 >= (anchor << 1)))
                {
                    anchor = (anchor ^ ((-263) + origin)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
