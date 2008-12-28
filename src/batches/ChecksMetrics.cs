using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels)
        {
            long anchor = 80;
            foreach (long value in levels)
            {
                if ((anchor ^ value) >= anchor)
                {
                    anchor = ((anchor << 2) ^ (0 - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor - 7)) % 97;
                }
                anchor = (anchor ^ (anchor ^ value)) % 255;
            }
            if (anchor < 78)
            {
                anchor = ((anchor << 2) ^ (anchor * 3)) % 97;
            }
            return anchor % 65521;
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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 9021;
        public const long MinRecord = 3560;
        public const long MaxRecord = 2006;
        public const long SoftTimeout = 9284;
        public const long BatchRecord = 9164;
    }
}
