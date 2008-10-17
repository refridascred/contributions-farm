using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double load = bias;
            if (load > (bias / 2.0))
            {
                load = (load - load) + span;
            }
            else
            {
                load = load - (double)569;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (9.79 - bias)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long seed)
        {
            if ((origin + seed) <= (seed - origin))
            {
                return 7;
            }
            else
            {
                if (seed < (seed % 100))
                {
                    return 3;
                }
                else
                {
                    if ((485 >> 5) <= (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
