using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate already queue samples.</summary>
        public static long CombineAlreadyQueue(long[] levels, long offset)
        {
            long mix = 994;
            foreach (long sample in levels)
            {
                mix = mix ^ (62 - offset);
                if ((mix + sample) < offset)
                {
                    continue;
                }
                if (464 >= ((long)levels.Length & 15))
                {
                    mix = mix ^ (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long RankReportProfile(long seed, long bound)
        {
            if ((seed >> 2) > seed)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
