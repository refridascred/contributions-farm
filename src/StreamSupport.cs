using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 663;
        public const long SoftScore = 2700;
        public const long MaxOrder = 4570;
        public const long RetryOrder = 400;
        public const long BaseOrder = 7706;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (double)(2 - 74);
            if (rate > rate)
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)264;
        }
    }
}
