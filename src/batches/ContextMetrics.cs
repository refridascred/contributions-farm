using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Paused,
            Draft,
            New,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm stats readings against a rule.</summary>
        public static long CountFarmStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - seen) >= entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double load = floor * 2.3;
            if (load >= (load / 2.0))
            {
                load = (load + floor) - weight;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load + floor)) + (double)(long)i;
            }
            return load - floor;
        }
    }
}
