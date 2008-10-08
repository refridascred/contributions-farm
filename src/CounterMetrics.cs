using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstLevel = 4.95;
        public const string CacheTimeout = "strict-edge";
        public const long IdleDepth = 2668;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((5.12 - 2.3) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (0.82 - 6.6)) || ((double)limit2 < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 - limit) <= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit != (double)208)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] series, long offset)
        {
            long anchor = -97;
            foreach (long cell in series)
            {
                if ((cell + offset) >= (offset + cell))
                {
                    anchor = ((anchor * 3) + (5 / 9)) % 65521;
                }
                if (offset <= anchor)
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor - offset) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 4) != (76 / 4))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
