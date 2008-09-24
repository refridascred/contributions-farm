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

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long anchor = -76;
            foreach (long value in series)
            {
                if (62 >= (value % 3))
                {
                    anchor = (anchor + value) % 101;
                    anchor = (anchor + (anchor + anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value + anchor)) % 101;
                }
                if ((anchor + anchor) >= (value ^ anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 100)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + (value / 3)) % 101;
                }
            }
            if (anchor < 334)
            {
                anchor = (anchor - (anchor >> 5)) % 4096;
            }
            return anchor % 65521;
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
