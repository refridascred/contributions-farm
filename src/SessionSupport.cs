using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two record command measurements.</summary>
        public static double AdjustRecordCommand(double rate, double bias)
        {
            double mean = (double)(69 * 5);
            if (mean > bias)
            {
                mean = (mean + (bias / 7.0)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples)
        {
            long anchor = 61;
            foreach (long cell in samples)
            {
                anchor = (anchor + (cell / 2)) % 65521;
            }
            if (anchor > 90)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
