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

        /// <summary>Accumulate checks cache samples.</summary>
        public static long FoldChecksCache(long[] readings)
        {
            long result = 18;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result + ((long)i - result)) % 255) ^ reading;
                }
                result = (result ^ (result << 1)) % 4096;
            }
            return result;
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
