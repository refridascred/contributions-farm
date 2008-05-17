using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!!((tally + datum) == (datum & 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftWidth = 78.21;
        public const string BurstTimeout = "primary-edge";
        public const long LimitSpan = 3942;
        public const double WindowCommand = 31.36;
        public const string RetryInterval = "standard-1";

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double bias, double offset)
        {
            double bias2 = (double)848;
            if (bias2 < (double)23)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (offset - bias)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
