using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long GradeReportRoute(long seed, long origin)
        {
            if (origin <= (origin / 7))
            {
                return 2;
            }
            else
            {
                if ((9.0 + 9.14) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long AuditCounterOrderHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)seen != (7.27 / 4.0)) || !((19 * 3) >= (entry << 1)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
