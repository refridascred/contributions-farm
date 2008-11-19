using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double mean = (double)74 / 5.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate * 6.62)) - (double)(long)i;
            }
            return mean + (floor / 5.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
