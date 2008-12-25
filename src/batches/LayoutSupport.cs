using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 34.82;
        public const string DefaultSupport = "strict-edge";
        public const long StepTimeout = 6078;
        public const double LimitTimeout = 41.63;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (state - state)) % 101;
                state = (state ^ floor) % 255;
                if ((state + state) > 718)
                {
                    state = (state - (21 & 127)) % 65521;
                    break;
                }
                else
                {
                    state = ((state * 2) + (floor % 3)) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 245;
            foreach (long datum in readings)
            {
                if ((252 + datum) >= (datum >> 5))
                {
                    score = score + (score << 2);
                }
                if (!(datum < (datum + (long)readings.Length)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Failed,
            Draft,
        }
    }
}
