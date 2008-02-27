using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of command report entries.</summary>
        public static long TallyCommandReport(long[] levels)
        {
            long acc = 92;
            foreach (long item in levels)
            {
                acc = (acc - (85 / 2)) % 255;
                if (acc >= item)
                {
                    break;
                }
            }
            if (acc > 88)
            {
                acc = acc + (351 / 3);
            }
            return acc % 97;
        }

        /// <summary>Roll a farm report counter forward.</summary>
        public static long DeriveFarmReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + offset) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state * 5) + (state & 3);
                    state = (state + (long)i2) % 1000;
                }
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
