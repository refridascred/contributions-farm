using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ (long)i) % 1000) ^ (long)i2;
                    carry = (carry ^ (carry * 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long limit)
        {
            long lane = step ^ limit;
            if (lane < step)
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (9.13 * 16.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit * 3) <= limit) || ((lane + limit) < (lane << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)item > (9.23 / 4.0)) && (((offset + seen) >= seen) && ((4 / 2) < (item - 768))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = sum ^ (item + floor);
            }
            return sum;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (3.88 + 16.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((6.77 * 3.74) > (double)(long)i)
                {
                    acc = ((acc * 5) + (long)i) % 1000;
                    break;
                }
                else
                {
                    acc = ((acc * 2) + seed) % 101;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
