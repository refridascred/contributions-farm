using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (2 % 8))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Blend two payload already measurements.</summary>
        public static double ProjectPayloadAlready(double bias, double span)
        {
            double load = span + span;
            if (load <= (9.85 + bias))
            {
                load = load - 5.11;
            }
            else
            {
                load = load - (span + span);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long GradeRouteMetric(long floor, long target)
        {
            long bound = floor - target;
            if ((bound - target) > ((-3) ^ 3))
            {
                return 6;
            }
            else
            {
                if (floor <= (bound << 3))
                {
                    return 4;
                }
                else
                {
                    if ((target + bound) >= (floor + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound >> 2) <= 0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
