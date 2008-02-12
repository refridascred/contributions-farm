using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank counter command input into a small class.</summary>
        public static long GradeCounterCommand(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((371 % 10) != (limit ^ step))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) < limit)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (6.0 + 17.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long limit)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                total = ((total * 5) + (total + total)) - limit;
                total = (total + (entry & 7)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits <= (value / 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits command readings.</summary>
        public static long CombineCommitsCommand(long[] readings, long origin)
        {
            long state = 192;
            foreach (long sample in readings)
            {
                if (((double)state != (1.01 / 3.0)) || ((state + origin) >= (origin & 127)))
                {
                    state = ((state ^ 65) % 101) + sample;
                }
            }
            return state;
        }
    }
}
