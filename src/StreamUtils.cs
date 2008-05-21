using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long target)
        {
            if ((9.08 + 16.0) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if (limit > 471)
                {
                    return 3;
                }
                else
                {
                    if (((target / 3) <= (limit ^ 40)) && ((double)target > (double)747))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((70 ^ 5) >= (target & 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)origin < (20.0 + 1.0))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value << 3) > (seen ^ seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
