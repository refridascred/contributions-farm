using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7882;
        public const long MaxSpan = 2040;
        public const long RetryAccount = 6277;
        public const long SoftWidth = 5284;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long step)
        {
            if ((3.0 * 13.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((floor - step) > step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate graph format samples.</summary>
        public static long CombineGraphFormat(long[] data)
        {
            long mark = 327;
            foreach (long reading in data)
            {
                if ((mark - reading) != (reading - mark))
                {
                    mark = (mark ^ ((-210) << 1)) % 255;
                }
            }
            return mark;
        }
    }
}
