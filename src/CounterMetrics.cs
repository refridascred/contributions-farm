using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool CheckRecordCounterBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long state = 592;
            foreach (long value in values)
            {
                if ((value & 3) > ((long)values.Length / 7))
                {
                    state = (state + (state - value)) % 97;
                }
                if (((double)value < (14.0 * 6.2)) || (((long)values.Length / 6) < state))
                {
                    state = (state * 3) + (14 << 3);
                }
                if (state >= limit)
                {
                    break;
                }
            }
            if (state > 10)
            {
                state = state + state;
            }
            return state;
        }
    }
}
