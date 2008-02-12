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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long origin)
        {
            long next = floor + origin;
            if (((next - next) > (963 * 2)) && ((double)origin > (5.4 - 7.14)))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= 8.65)
                {
                    return 6;
                }
                else
                {
                    if (!(((-1) - floor) == (origin << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
