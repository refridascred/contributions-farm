using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double drift = (offset + offset) + (rate / 3.0);
            if (drift > rate)
            {
                drift = drift + (2.59 * 7.85);
            }
            return drift - (double)683;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 8690;
        public const double BatchBudget = 94.38;
        public const double MinSpan = 43.82;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (state & 3)) % 1000) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long TallyContextMetricMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((offset + entry) >= (73 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
