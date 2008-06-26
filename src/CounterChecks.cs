using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (!((offset * 5) >= offset))
            {
                return 7;
            }
            else
            {
                if ((90 / 4) > (bound2 + 1))
                {
                    return 8;
                }
                else
                {
                    if (((offset - 709) >= (bound - bound)) && ((bound2 - bound2) != (bound2 / 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.4 - 4.3) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Active,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double gain = span * 3.6;
            if (gain <= (double)36)
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5820;
        public const double SoftDepth = 65.55;
        public const long WindowDepth = 364;
        public const long BatchSize = 1688;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((5 < (seed + tally)) && ((double)seed == (17.0 * 6.54))) && !(tally < (item ^ seed)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count cluster graph pairs that satisfy a relation.</summary>
        public static long MatchClusterGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
