using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 5392;
        public const long SoftChannel = 8001;
        public const string IdleScore = "primary-edge";
        public const long MaxChannel = 8625;
        public const long BatchChannel = 6456;

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((sample - score) == (21 + score))
                {
                    score = score + score;
                }
            }
            if (score < 0)
            {
                score = ((score * 5) + (score + 277)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
