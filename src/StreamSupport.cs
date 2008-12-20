using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)limit > (double)mix))
                {
                    mix = ((mix << 3) ^ (2 << 2)) % 101;
                    mix = ((mix * 4) + (limit + limit)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long state = 3;
            foreach (long value in samples)
            {
                state = state ^ (value * 2);
                state = (state + (value - value)) % 65521;
            }
            if (state > (-80))
            {
                state = (state << 2) ^ (state / 3);
            }
            return state % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 3634;
        public const long StepInterval = 7512;
        public const double SoftContext = 40.43;
    }
}
