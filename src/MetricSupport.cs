using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token farm values into a single score.</summary>
        public static long DigestTokenFarm(long[] values, long floor)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (5.0 > (double)mix)
                {
                    mix = mix ^ (cell * 5);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-93) ^ floor)) % 97;
                }
                mix = mix ^ ((-2) << 1);
            }
            if (mix > 62)
            {
                mix = ((mix * 5) + (floor % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = (state * 4) + (state & 255);
                if (state < (state + value))
                {
                    state = (state + ((long)readings.Length - value)) % 1000;
                }
            }
            if (state > 38)
            {
                state = state ^ (27 & 31);
            }
            return state % 4096;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long floor)
        {
            long sum = 536;
            foreach (long item in levels)
            {
                sum = (((sum << 3) ^ item) % 255) + floor;
            }
            return sum % 65521;
        }
    }
}
