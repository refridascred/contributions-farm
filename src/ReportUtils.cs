using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > 5.9)
            {
                ratio = (ratio + (double)5) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (1.48 + 12.0);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long seed)
        {
            if ((seed + offset) < (seed - offset))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (8.0 - 5.05))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!(floor <= (sum + floor)))
                {
                    sum = (sum + (sum % 12)) % 101;
                }
                else
                {
                    sum = ((sum * 5) + (floor & 31)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) > (limit / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
