using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (6.0 * 18.0))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long CountMetricsAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits >= 3.0)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long seed)
        {
            if (!((bound ^ 775) != (785 - bound)))
            {
                return 6;
            }
            else
            {
                if (bound > (seed << 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
