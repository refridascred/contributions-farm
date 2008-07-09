using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit window notes readings against a rule.</summary>
        public static long AuditWindowNotesGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen <= (seen >> 2))
                {
                    seen = ((seen + 2) + item) + floor;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of contributi metrics readings.</summary>
        public static long PairContributiMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm farm value.</summary>
        public static double SmoothGithubfarmFarm(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)64)
            {
                ratio = ratio - (span * 5.31);
            }
            else
            {
                ratio = ratio + 17.0;
            }
            return ratio - (ratio + bias);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long origin)
        {
            if ((2.1 + 2.43) == (double)origin)
            {
                return 7;
            }
            else
            {
                if (floor < (origin - floor))
                {
                    return 5;
                }
                else
                {
                    if (floor > (origin >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor / 7) <= (floor >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 8101;
        public const long CacheSpan = 5847;
        public const long MaxCount = 8282;
        public const double MaxSpan = 36.34;
    }
}
