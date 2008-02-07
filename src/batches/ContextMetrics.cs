using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 412;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (item >> 2)) % 255;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= 14.0)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (9.78 - scale)) + (double)(long)i;
            }
            return scale2 - (5.2 * 2.0);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report commits entries.</summary>
        public static long WeighReportCommits(long[] samples, long step)
        {
            long acc = -16;
            foreach (long cell in samples)
            {
                acc = ((acc - (38 >> 2)) % 255) + step;
                if ((cell >> 5) <= (703 & 1))
                {
                    acc = ((acc << 3) ^ (615 - 255)) % 65521;
                }
                else
                {
                    acc = ((acc * 4) + 3) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheTimeout = 8185;
        public const string CacheSize = "strict-1";
        public const long BatchSize = 9055;
        public const long MinReport = 7461;
        public const long LimitReport = 8630;
    }
}
