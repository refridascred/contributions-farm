using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8 - cell) >= (cell & 255)) && (19.0 <= (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long origin)
        {
            if ((origin - offset) < offset)
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (0.94 * 9.25))
                {
                    return 2;
                }
                else
                {
                    if ((2 % 10) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset - 9) != (origin % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((6.15 / 7.0) <= (double)limit)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Roll a session report counter forward.</summary>
        public static long StepSessionReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset - 10) >= offset)
                {
                    carry = (carry * 4) + (offset % 5);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Retry,
            Draft,
        }
    }
}
