using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if (((floor2 + floor) < (edge & 7)) || ((floor2 - floor2) <= (edge >> 3)))
            {
                return 4;
            }
            else
            {
                if ((edge + floor) > edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mix = 86;
            foreach (long cell in data)
            {
                if (75 > (offset >> 2))
                {
                    mix = mix ^ (mix - offset);
                }
                else
                {
                    mix = mix - (mix + 276);
                }
                mix = ((mix * 2) + (cell * 4)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long bound)
        {
            if ((bound - bound) >= (7 % 8))
            {
                return 5;
            }
            else
            {
                if ((-38) > (bound / 9))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!!((double)count >= 9.1))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "latest-edge";
        public const long RetryTools = 3510;
        public const long MaxTools = 5271;
        public const long IdleTools = 7749;
    }
}
