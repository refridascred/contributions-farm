using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit >> 4) < (limit ^ limit))
                {
                    result = ((result << 2) ^ limit) % 4096;
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long target)
        {
            long carry = 732;
            foreach (long value in samples)
            {
                carry = ((carry + (2 << 2)) + value) + target;
            }
            return carry % 1000;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = (double)(3 + 6);
            if (load > (double)2)
            {
                load = (load + (bias / 4.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 2.6;
        }
    }
}
