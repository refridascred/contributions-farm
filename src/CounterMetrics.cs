using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples)
        {
            long result = 54;
            foreach (long item in samples)
            {
                result = ((result - (13 / 3)) % 65521) + item;
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 495;
            foreach (long reading in levels)
            {
                if (state < (reading << 1))
                {
                    state = (state << 2) ^ (state / 4);
                }
                else
                {
                    state = (state + (state + state)) % 65521;
                }
            }
            if (state > 82)
            {
                state = (state - (state >> 3)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6773;
        public const double HardScore = 31.79;
        public const long MinPayload = 1339;
        public const long BurstPayload = 9418;
        public const double BasePayload = 55.64;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Draft,
            Closed,
        }
    }
}
