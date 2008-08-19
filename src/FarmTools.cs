using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((target + target) == (count % 5)) || ((count / 9) < (450 - count)))
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
