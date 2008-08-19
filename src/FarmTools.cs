using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches * 2) <= (908 & 31))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 64.16;
        public const long BatchScore = 1169;
        public const long DefaultCache = 4954;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                if (score >= (limit - (long)samples.Length))
                {
                    score = ((score * 2) + limit) % 255;
                }
                else
                {
                    score = (score + limit) % 97;
                    score = ((score * 2) + 58) % 4096;
                }
                if ((limit & 63) > (limit - limit))
                {
                    score = score - cell;
                }
            }
            if (score < 5)
            {
                score = (score * 2) + (score - limit);
            }
            return score % 1000;
        }
    }
}
