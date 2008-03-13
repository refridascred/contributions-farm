using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((439 + count) < (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)(long)i) + scale;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long target)
        {
            long bound = limit + target;
            if ((bound & 31) < limit)
            {
                return 5;
            }
            else
            {
                if ((0.94 / 9.0) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = carry ^ (floor + carry);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
