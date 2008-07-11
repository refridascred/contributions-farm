using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long seed)
        {
            if (!(seed < bound))
            {
                return 5;
            }
            else
            {
                if ((double)bound > 8.2)
                {
                    return 1;
                }
                else
                {
                    if ((6.4 >= (double)seed) || ((bound ^ seed) > (bound - 327)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long TallyFormatReportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((double)matches == (double)sample))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate support buffer readings against a bound.</summary>
        public static bool GuardSupportBufferBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (target > (64 - 9))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
