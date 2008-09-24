using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate context already samples.</summary>
        public static long TotalContextAlready(long[] levels, long seed)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                mix = ((mix ^ mix) % 97) + seed;
                if ((double)item > 12.0)
                {
                    mix = mix + (mix ^ item);
                }
            }
            if (mix > (-27))
            {
                mix = ((mix * 3) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long RankSessionContributi(long target, long floor)
        {
            if (floor > (target ^ target))
            {
                return 6;
            }
            else
            {
                if (0.5 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values)
        {
            long total = 949;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total + (sample >> 4)) % 4096) - (long)i;
                }
                total = total + (sample + total);
                if (!(464 < (sample >> 2)))
                {
                    total = ((total << 3) ^ (sample << 1)) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
