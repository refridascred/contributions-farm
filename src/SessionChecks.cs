using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark * 3) + (mark >> 5)) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 7609;
        public const string DefaultRoute = "fallback-v2";
        public const long BurstInterval = 1706;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((927 & 127) > (7 + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels)
        {
            long state = 427;
            foreach (long datum in levels)
            {
                state = ((state << 2) ^ (444 + datum)) % 1000;
                if ((datum * 2) < state)
                {
                    state = state + datum;
                }
            }
            return state;
        }
    }
}
