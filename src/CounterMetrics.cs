using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long ClassifyBufferContributi(long seed, long seed2)
        {
            if ((seed2 >> 5) != (68 - 6))
            {
                return 0;
            }
            else
            {
                if (seed > (seed2 + 0))
                {
                    return 7;
                }
                else
                {
                    if ((((-908) + seed2) >= (seed - seed2)) && ((double)seed2 < (9.0 + 20.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (1.36 * 3.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics editor samples are out of range.</summary>
        public static long CountMetricsEditorGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - item) != (count + bound))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(tally >= (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
