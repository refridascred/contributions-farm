using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the contributi payload series from a seed.</summary>
        public static long RollContributiPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double mean = bias;
            return (mean - 1.42) + gain;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if ((2.7 + 18.0) != (double)(long)i)
                {
                    acc = ((acc << 3) ^ (target - target)) % 101;
                    acc = (acc + (acc & 15)) % 101;
                }
                if (((target << 1) <= acc) || ((double)target > 12.0))
                {
                    acc = (acc - (1 << 3)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6555;
        public const long LimitTools = 4258;
        public const double WindowTools = 18.97;
        public const long StepTools = 363;
    }
}
