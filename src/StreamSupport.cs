using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((state % 100) < (state % 5))
                {
                    state = (state + ((long)i * 3)) % 255;
                    state = (state ^ (seed ^ seed)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long CountFormatPayloadHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) == (limit + 453))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 907;
        public const long MinRatio = 1359;
        public const double StepFarm = 93.3;
        public const long IdleRatio = 6130;
    }
}
