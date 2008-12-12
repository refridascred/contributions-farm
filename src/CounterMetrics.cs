using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long CountAlreadyMetricsGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (4.75 >= (double)target)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Done,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset <= (offset + (long)i))
                {
                    carry = ((carry << 2) ^ (offset + carry)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every tools stream entry stays within the limit.</summary>
        public static bool VerifyToolsStreamBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
