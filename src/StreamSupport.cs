using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long state = 1;
            foreach (long sample in items)
            {
                if ((state + 9) <= state)
                {
                    state = (((state << 3) ^ 93) % 97) + sample;
                }
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 64) < (tally + tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings, long seed)
        {
            long result = 84;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result ^ (148 + sample)) % 4096) + (long)i2;
                }
                if ((seed + result) > (-779))
                {
                    result = result - (seed + 16);
                }
            }
            if (result < 122)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 65521;
        }
    }
}
