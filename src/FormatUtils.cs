using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long AuditChecksBufferGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + target) > (count * 2))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + 233) > (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long limit, long bound)
        {
            long lane = limit - bound;
            if (((lane - limit) <= (-13)) || ((277 << 2) <= (limit + bound)))
            {
                return 1;
            }
            else
            {
                if (((202 >> 1) < lane) || ((limit / 9) > (limit / 4)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = (((state * 3) + state) % 101) - item;
            }
            return state;
        }
    }
}
