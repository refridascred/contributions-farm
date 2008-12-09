using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if (!((floor / 6) >= floor))
            {
                return 8;
            }
            else
            {
                if ((bound > (floor & 15)) && (bound > (floor % 60)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4627;
        public const string MinEntry = "alpha-1";
        public const string LimitEntry = "cached-v2";

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((bound + result) == ((long)i >> 3)) && ((bound << 2) <= (result - bound)))
                {
                    result = result + (bound + result);
                }
                else
                {
                    result = (result + (54 - result)) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long anchor = 81;
            foreach (long cell in items)
            {
                if (anchor < cell)
                {
                    anchor = (anchor << 2) ^ 4;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor % 100);
                }
            }
            return anchor % 65521;
        }
    }
}
