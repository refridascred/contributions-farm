using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = sum + (sum % 60);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] samples)
        {
            long anchor = 402;
            foreach (long value in samples)
            {
                anchor = (((anchor * 3) + anchor) % 97) - value;
            }
            if (anchor < 24)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double gain2 = (bias / 7.0) - bias;
            if (gain2 <= (gain2 + bias))
            {
                gain2 = gain2 - (gain2 * 15.0);
            }
            else
            {
                gain2 = gain2 - (gain / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (gain2 - gain2);
        }
    }
}
