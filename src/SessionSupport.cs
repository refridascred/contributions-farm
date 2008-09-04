using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a already counter counter forward.</summary>
        public static long SeriesAlreadyCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 5) + (target & 31);
                if (target > anchor)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long score = 452;
            foreach (long value in data)
            {
                score = (score * 2) + (value + target);
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings, long bound)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                if (!((double)score < (1.9 + 18.0)))
                {
                    score = (((score << 2) ^ (1 << 1)) % 97) - bound;
                }
                else
                {
                    score = (score * 2) + (sample * 4);
                }
            }
            return score % 97;
        }
    }
}
