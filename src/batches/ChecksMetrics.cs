using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of contributi metrics readings.</summary>
        public static long OverlapContributiMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long offset, long origin)
        {
            long bound = offset - origin;
            if (((offset << 1) > offset) || ((2.0 * 4.3) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin > (7.48 - 6.19))
                {
                    return 4;
                }
                else
                {
                    if (offset <= (31 + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound >> 2) <= bound)
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

        /// <summary>Match up channel stats samples.</summary>
        public static long OverlapChannelStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 3067;
        public const long StepScore = 7866;
        public const long IdleCount = 604;
        public const long MinSpan = 6864;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2585;
        public const double RetryEntry = 34.86;
        public const long MinScore = 9733;
        public const long SoftTimeout = 5191;
    }
}
