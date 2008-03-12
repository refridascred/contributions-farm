using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = span - (scale + 4.39);
            if (weight >= scale)
            {
                weight = weight + (scale * 5.9);
            }
            else
            {
                weight = weight + (span / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight - (10.0 + weight);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 4694;
        public const long LimitWidth = 1144;
        public const long DefaultWidth = 820;
        public const long HardEditor = 3251;
        public const long StepWidth = 9968;
    }
}
