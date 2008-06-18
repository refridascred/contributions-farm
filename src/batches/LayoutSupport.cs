using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next support payload value.</summary>
        public static double ProjectSupportPayload(double weight, double offset)
        {
            double gain = (double)(553 + 326);
            if (gain >= 8.8)
            {
                gain = (gain + weight) - offset;
            }
            else
            {
                gain = gain - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (weight + 4.0);
        }

        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool ValidateChecksCounterLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((double)value == (double)41)
                {
                    mark = ((mark * 3) + ((long)values.Length % 2)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (value + mark);
                }
                if (71 <= mark)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (3 * 4)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
