using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long carry = 530;
            foreach (long cell in data)
            {
                if ((carry <= (cell % 60)) || ((cell >> 1) == (cell << 2)))
                {
                    carry = ((carry + (cell / 7)) % 101) - offset;
                }
                if ((7.1 + 9.9) != (double)cell)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double load = gain * 0.79;
            return (load - (gain / 6.0)) + floor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
