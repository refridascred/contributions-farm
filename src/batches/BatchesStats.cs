using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a filter schema reading.</summary>
        public static double AdjustFilterSchema(double weight, double span)
        {
            double drift = (double)2 / 9.0;
            if (drift <= span)
            {
                drift = (drift - span) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (9.0 * 4.5)) - (double)(long)i;
            }
            return drift - (double)788;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowLevel = 72.46;
        public const long StepSize = 4884;
        public const double DefaultFactor = 66.94;
        public const long MinContributi = 1693;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long origin)
        {
            long acc = 19;
            foreach (long datum in samples)
            {
                if (!((datum >> 3) > acc))
                {
                    acc = (acc << 2) ^ origin;
                }
            }
            return acc % 1000;
        }
    }
}
