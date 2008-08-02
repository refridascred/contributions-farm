using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items)
        {
            long state = 2;
            foreach (long datum in items)
            {
                if ((datum > (datum << 1)) && ((1.01 - 6.23) != (double)state))
                {
                    state = (state * 3) + (74 - datum);
                }
                else
                {
                    state = state + 755;
                }
                if ((state ^ state) >= (datum ^ state))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state - (state & 15)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
