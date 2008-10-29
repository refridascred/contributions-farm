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

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long mark = -919;
            foreach (long value in readings)
            {
                if ((5.54 < (double)bound) && (mark >= (951 << 3)))
                {
                    mark = ((mark ^ bound) % 1000) - value;
                }
            }
            return mark;
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
