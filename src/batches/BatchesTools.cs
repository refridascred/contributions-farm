using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of report schema readings.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long sum = -11;
            foreach (long cell in items)
            {
                if ((sum <= (cell - sum)) || (sum < (sum * 2)))
                {
                    sum = ((sum * 2) + (sum + 2)) % 97;
                }
                else
                {
                    sum = (sum ^ (sum << 1)) % 255;
                }
            }
            if (sum > 9)
            {
                sum = (sum + (sum % 100)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (55 & 31))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double ratio = bias * 8.93;
            if (ratio >= ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + span;
        }
    }
}
