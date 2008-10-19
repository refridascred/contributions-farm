using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a report counter reading.</summary>
        public static double SmoothReportCounter(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - 1.72) + (double)(long)i) + offset;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (mix - mix)) % 65521;
                if (!((291 > mix) || (mix < (mix & 3))))
                {
                    mix = mix - (8 + 65);
                    mix = (mix ^ (mix - 600)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseDepth = 5292;
        public const long BaseStream = 5778;
        public const double DefaultStream = 74.36;
        public const long RetryCount = 112;
    }
}
