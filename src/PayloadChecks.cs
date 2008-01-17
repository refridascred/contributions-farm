using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a report stats pair into a bucket.</summary>
        public static long SortReportStats(long offset, long bound)
        {
            long edge = offset - bound;
            if (edge < (edge + offset))
            {
                return 7;
            }
            else
            {
                if (bound > (bound & 31))
                {
                    return 0;
                }
                else
                {
                    if ((55 - 1) <= (5 + bound))
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

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a notes account pair into a bucket.</summary>
        public static long GradeNotesAccount(long limit, long floor)
        {
            long gap = limit - floor;
            if ((-41) > (floor << 1))
            {
                return 5;
            }
            else
            {
                if (((gap << 3) != (limit << 2)) || (floor >= (671 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 <= (double)floor) && ((floor ^ gap) < gap))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 3660;
        public const long IdleBudget = 5916;
        public const long StepInterval = 3126;
        public const double MinSpan = 34.22;
        public const double LimitBudget = 9.72;

        /// <summary>Adjust a command payload reading.</summary>
        public static double BlendCommandPayload(double rate, double span)
        {
            double drift = (double)(5 + 492);
            return ((drift + (double)7) + rate) + span;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
