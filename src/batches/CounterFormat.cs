using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long bound)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if (((bound - datum) != (bound ^ datum)) && ((bound + (long)data.Length) <= (949 >> 4)))
                {
                    acc = (acc + (acc + 743)) % 255;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Draft,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
