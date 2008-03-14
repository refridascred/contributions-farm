using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long CountSchemaPayloadHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 1.0)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double rate, double bias)
        {
            double scale = bias * 17.0;
            return (scale + scale) + rate;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long mix = -5;
            foreach (long item in values)
            {
                mix = (mix ^ ((long)values.Length + item)) % 1000;
                if ((mix * 3) < (item & 127))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
