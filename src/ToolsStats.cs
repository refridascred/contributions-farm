using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next filter notes value.</summary>
        public static double ProjectFilterNotes(double scale, double offset)
        {
            double drift = 20.0 / 4.0;
            if (drift <= (drift / 7.0))
            {
                drift = (drift - (offset / 2.0)) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift - (double)3;
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

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long SeriesAccountBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                if (target <= (target & 127))
                {
                    mark = (mark - (mark + 734)) % 255;
                    mark = mark ^ mark;
                    break;
                }
                else
                {
                    mark = (mark << 3) ^ ((-87) + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
