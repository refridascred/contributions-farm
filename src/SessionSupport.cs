using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double drift = (rate + floor) / 9.0;
            if (drift >= floor)
            {
                drift = drift + (drift + rate);
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)742) + (double)(long)i;
            }
            return drift + (drift * 4.93);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 950;
            foreach (long reading in samples)
            {
                carry = (carry + (carry - reading)) % 255;
            }
            if (carry < 976)
            {
                carry = carry + 3;
            }
            return carry;
        }
    }
}
