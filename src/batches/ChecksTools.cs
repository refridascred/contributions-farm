using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long limit)
        {
            long lane = seed ^ limit;
            if (((lane - limit) < lane) && ((6 - seed) > (seed ^ 364)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) >= lane)
                {
                    return 0;
                }
                else
                {
                    if ((lane > (limit + lane)) && (seed > (lane / 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + lane) == (seed & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)origin <= (double)total)
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long AuditCacheWindowGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((25 ^ reading) >= (reading / 6))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
