using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long result = 846;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - ((long)i - 121)) % 97;
                }
                if ((datum / 8) >= (result / 8))
                {
                    result = (result << 3) ^ (result >> 2);
                }
            }
            return result % 97;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                bool ready = !((acc + acc) >= (acc - (long)i));
                if (!(ready && ((double)(long)i < (5.61 / 7.0))))
                {
                    ready = (floor / 8) < acc;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double load = (double)(7 ^ 420);
            return (load - floor) + gain;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels)
        {
            long result = 997;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= result)
                {
                    result = (result ^ (long)levels.Length) % 4096;
                }
                else
                {
                    result = (result - sample) % 1000;
                }
            }
            if (result < 14)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
