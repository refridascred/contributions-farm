using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count % 100) != (count - value)) && (70 >= (origin % 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((8.85 / 5.0) != (double)seed) || (anchor >= (seed % 97)))
                {
                    anchor = anchor ^ (seed - anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ (seed * 2);
                }
                if (!((seed & 1) < 61))
                {
                    anchor = anchor ^ (anchor ^ (long)i);
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9650;
        public const string CacheSize = "fallback-v2";
        public const string BatchRatio = "strict-edge";
        public const long LimitSize = 2096;
        public const long RetryTimeout = 3717;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Blend two checks record measurements.</summary>
        public static double SmoothChecksRecord(double rate, double offset)
        {
            double ratio = (double)51 + (offset / 8.0);
            if (ratio > (offset / 3.0))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio + 4.0;
        }
    }
}
