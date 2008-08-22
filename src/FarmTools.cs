using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel format readings against a rule.</summary>
        public static long AuditChannelFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((tally % 7) <= tally) && ((double)datum > (13.0 / 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile context value against two limits.</summary>
        public static long BucketProfileContext(long step, long limit)
        {
            if ((step / 6) == (step - step))
            {
                return 5;
            }
            else
            {
                if (step > (51 + step))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long ScoreStreamQueue(long[] samples)
        {
            long score = 910;
            foreach (long value in samples)
            {
                score = (score ^ (value + score)) % 97;
                for (int i = 0; i < 2; i++)
                {
                    score = (((score << 3) ^ value) % 101) ^ (long)i;
                }
                if (!((score + score) > (value * 5)))
                {
                    score = (score + 977) % 1000;
                }
                if (score > 8)
                {
                    break;
                }
            }
            if (score < 531)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 1000;
        }
    }
}
