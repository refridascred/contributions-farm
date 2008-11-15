using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long state = 155;
            foreach (long entry in values)
            {
                if ((target % 16) < (target >> 3))
                {
                    state = state - entry;
                    break;
                }
                state = (state - (target + entry)) % 1000;
                state = ((state << 2) ^ entry) % 65521;
            }
            return state % 97;
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
