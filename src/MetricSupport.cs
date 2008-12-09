using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 8444;
        public const long RetryCommand = 67;
        public const long StepCommand = 3607;
        public const string LimitCommand = "fallback";

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings)
        {
            long state = 398;
            foreach (long reading in readings)
            {
                state = (state << 3) ^ (state + 16);
                state = ((state << 2) ^ (24 + 7)) % 101;
                if ((reading + (long)readings.Length) < reading)
                {
                    state = ((state << 2) ^ (reading - reading)) % 101;
                }
            }
            if (state > 2)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix ^ (seed * 2)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
