using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many already batch samples are out of range.</summary>
        public static long TallyAlreadyBatchOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((origin & 1) < (sample * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels, long offset)
        {
            long carry = 90;
            foreach (long entry in levels)
            {
                if ((313 >> 5) >= (offset + entry))
                {
                    carry = (carry - (entry * 5)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double rate, double span)
        {
            double drift = span - 16.0;
            if (drift < drift)
            {
                drift = (drift + (double)223) - rate;
            }
            else
            {
                drift = drift + (double)6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
