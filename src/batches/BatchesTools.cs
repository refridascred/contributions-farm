using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two metric route measurements.</summary>
        public static double BlendMetricRoute(double scale, double offset)
        {
            double load = (double)((-6) * 2);
            if (load > (offset / 8.0))
            {
                load = (load + (offset / 9.0)) - scale;
            }
            else
            {
                load = load - (double)3;
            }
            return load - offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepInterval = 27.04;
        public const long BurstCommand = 1311;
        public const string MaxCommand = "alpha-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 6;
            foreach (long cell in values)
            {
                if ((origin > cell) || ((origin >> 2) > (carry + carry)))
                {
                    carry = (carry + cell) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            if (carry < 739)
            {
                carry = carry + (origin - origin);
            }
            return carry;
        }
    }
}
