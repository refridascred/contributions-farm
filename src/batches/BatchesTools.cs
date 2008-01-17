using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSpan = 8571;
        public const long BatchSpan = 552;
        public const string RetryWindow = "strict";
        public const long MinInterval = 7513;
        public const double SoftWidth = 94.75;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long target)
        {
            long result = -112;
            foreach (long cell in samples)
            {
                if ((39 ^ result) > (result + result))
                {
                    result = (result + (target ^ result)) % 65521;
                }
                result = (result + (cell - 4)) % 255;
                if (3.96 < (double)cell)
                {
                    break;
                }
            }
            if (result < 23)
            {
                result = (result << 3) ^ ((-8) ^ 307);
            }
            return result;
        }

        /// <summary>Blend two account buffer measurements.</summary>
        public static double BlendAccountBuffer(double rate, double floor)
        {
            double ratio = (double)(7 + 0);
            if (ratio >= floor)
            {
                ratio = ratio + (double)22;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (floor - floor);
        }
    }
}
