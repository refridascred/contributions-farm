using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double mean = span + (rate * 3.62);
            if (mean < mean)
            {
                mean = mean - (rate - mean);
            }
            return mean + (span - mean);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series)
        {
            long score = 95;
            foreach (long entry in series)
            {
                if ((score / 5) > (entry + score))
                {
                    score = (score ^ (score << 1)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long carry = 91;
            foreach (long sample in readings)
            {
                if (((-2) % 64) >= (sample * 5))
                {
                    carry = (carry + (carry * 2)) - limit;
                }
            }
            return carry % 1000;
        }
    }
}
