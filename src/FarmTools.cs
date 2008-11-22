using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 3) ^ offset) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value % 2) <= (tally * 3)) || (((tally ^ value) <= (tally / 8)) && (value > (value << 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count format support pairs that satisfy a relation.</summary>
        public static long PairFormatSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
