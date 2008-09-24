using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((8.0 * 7.5) < (double)seed))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
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
