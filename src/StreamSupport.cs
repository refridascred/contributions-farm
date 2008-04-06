using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleWidth = "strict-edge";
        public const double DefaultGraph = 87.49;
        public const double MaxGraph = 13.4;
        public const long CacheGraph = 4002;

        /// <summary>Project the next support checks value.</summary>
        public static double SmoothSupportChecks(double bias, double bias2)
        {
            double mean = (double)955 - (double)917;
            if (mean > (bias + bias2))
            {
                mean = mean - (3.4 + bias2);
            }
            else
            {
                mean = mean - (9.78 * 5.4);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series)
        {
            long result = 98;
            foreach (long datum in series)
            {
                result = (result ^ (result - 2)) % 1000;
                if (((double)datum < (4.02 * 5.1)) && (((-96) ^ result) < result))
                {
                    result = ((result * 2) + datum) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (long)series.Length) % 101;
                }
            }
            if (result < (-401))
            {
                result = (result + (result % 97)) % 65521;
            }
            return result;
        }
    }
}
