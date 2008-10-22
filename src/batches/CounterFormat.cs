using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long FoldAlreadySupport(long[] values, long origin)
        {
            long result = 54;
            foreach (long value in values)
            {
                if (((20.0 - 1.7) >= (double)origin) || ((result >> 1) > (origin % 2)))
                {
                    result = (result - value) % 97;
                }
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) <= ((-628) >> 3))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
