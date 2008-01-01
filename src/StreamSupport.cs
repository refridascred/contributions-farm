using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2.65 + 5.4) < (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two batches token measurements.</summary>
        public static double SmoothBatchesToken(double bias, double span)
        {
            double bias2 = (double)8;
            if (bias2 >= (bias2 * 3.2))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            return bias2 + span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 2098;
        public const long StepNotes = 7202;
        public const long MaxCount = 7691;
        public const long RetryTimeout = 6645;
    }
}
