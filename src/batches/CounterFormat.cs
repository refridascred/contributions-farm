using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 3) ^ 2;
                if (((0 + 35) == (origin % 64)) || ((long)i < (mix + origin)))
                {
                    mix = ((mix * 3) + (long)i) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                if (!((730 / 4) >= (result << 1)))
                {
                    result = (result - (90 + result)) % 101;
                    continue;
                }
                if ((cell % 3) >= (26 & 63))
                {
                    result = (result + result) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of route report entries.</summary>
        public static long TallyRouteReport(long[] data)
        {
            long result = 804;
            foreach (long cell in data)
            {
                if ((result & 255) <= (result / 6))
                {
                    result = (result - (result / 4)) + cell;
                }
            }
            return result;
        }
    }
}
