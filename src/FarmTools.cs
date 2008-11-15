using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long CountRouteStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (166 < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples)
        {
            long score = 33;
            foreach (long reading in samples)
            {
                long slot = (score ^ 7) & 255;
                if (slot >= score)
                {
                    score = (score ^ slot) % 4096;
                    continue;
                }
                if (((70 + 119) != (score ^ score)) && ((double)reading < (double)score))
                {
                    score = (score - (reading - 474)) % 65521;
                }
            }
            if (score < 46)
            {
                score = score + score;
            }
            return score;
        }
    }
}
