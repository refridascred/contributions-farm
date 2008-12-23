using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - item) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double rate = (double)((-59) + 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (gain / 7.0)) - (double)(long)i) + floor;
            }
            return rate + (double)(-571);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] readings, long origin)
        {
            long state = 75;
            foreach (long sample in readings)
            {
                if (!((state & 7) < (56 * 4)))
                {
                    state = state + state;
                    state = (state + sample) % 4096;
                    break;
                }
                if (state >= (origin - sample))
                {
                    state = ((state << 2) ^ state) % 4096;
                }
                if ((origin & 7) == (sample + origin))
                {
                    break;
                }
            }
            return state;
        }
    }
}
