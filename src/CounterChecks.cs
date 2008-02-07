using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long sum = 62;
            foreach (long sample in data)
            {
                if (9 >= (sum + sample))
                {
                    sum = (sum * 4) + sum;
                }
                if (!((floor << 3) > floor))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit checks window readings against a rule.</summary>
        public static long CountChecksWindowMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen - reading) < (reading << 3))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((origin > (sample + sample)) || ((origin ^ 5) < 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long target, long limit)
        {
            if (!((double)target == (15.0 + 5.8)))
            {
                return 3;
            }
            else
            {
                if (((limit ^ (-44)) >= target) && ((target + 164) != (target & 255)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double ratio2 = (floor * 4.9) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio * 13.0)) + (double)(long)i;
            }
            return ratio2 + (ratio - ratio);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((15.0 - 8.0) == (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
