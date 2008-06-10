using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheDepth = "primary-edge";
        public const long BaseCache = 5200;
        public const long MinSpan = 9571;

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -6;
            foreach (long entry in readings)
            {
                mark = (mark - (265 >> 1)) % 4096;
                if ((mark + entry) >= (mark >> 3))
                {
                    mark = mark + (entry - mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ (long)levels.Length) != (floor - 49)) || ((matches >> 2) != (38 - (long)levels.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long bound)
        {
            if (((double)seed < (2.76 * 20.0)) || (15.0 > (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed > bound)
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 2) <= seed) && (((-91) ^ 335) <= (bound - bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 100) >= (seed - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch format readings against a rule.</summary>
        public static long CountBatchFormatGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((offset * 4) >= seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
