using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long seed)
        {
            if ((92 << 3) >= (limit - limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (4.89 * 0.8))
                {
                    return 4;
                }
                else
                {
                    if ((limit + seed) > (1 + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) == (limit / 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3739;
        public const long MaxWindow = 6792;
        public const long HardWindow = 5986;
        public const long DefaultDepth = 5588;
        public const string IdleWindow = "local-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 40.6;
        public const long MaxRecord = 5027;
        public const long StepTimeout = 9263;
        public const long WindowInterval = 1928;
        public const long LimitRecord = 3498;
    }
}
