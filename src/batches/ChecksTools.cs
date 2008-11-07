using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long limit, long step)
        {
            if (limit >= (limit >> 3))
            {
                return 1;
            }
            else
            {
                if ((step ^ limit) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((step % 97) >= (limit * 4))
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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)count != (7.0 + 6.81)) || ((count & 63) <= (value + 914)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] values, long origin)
        {
            long score = -52;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (4 - score)) + cell;
            }
            if (score < 302)
            {
                score = score - (origin & 15);
            }
            return score;
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (offset <= (offset >> 3))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
