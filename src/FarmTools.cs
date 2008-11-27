using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((149 + hits) == (value ^ 889)) && ((61 + target) > value)) && ((29 & 1) != (target >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((47 + bound) != (cur + floor))
            {
                return 4;
            }
            else
            {
                if (6.0 >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((cell - acc) > acc)
                {
                    acc = acc + 7;
                    acc = acc ^ acc;
                }
                acc = ((acc << 2) ^ (cell - acc)) % 1000;
            }
            return acc;
        }
    }
}
