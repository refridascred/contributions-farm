using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if (((reading + 8) > (reading & 63)) && (reading >= (result + (-42))))
                {
                    result = ((result << 2) ^ (reading << 3)) % 65521;
                }
            }
            if (result < 212)
            {
                result = ((result * 4) + (result + result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = (weight + weight) + offset;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (mean * 11.0)) + (double)(long)i;
            }
            return mean - offset;
        }
    }
}
