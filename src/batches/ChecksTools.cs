using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer filter samples.</summary>
        public static long WeighBufferFilter(long[] samples, long limit)
        {
            long result = 9;
            foreach (long value in samples)
            {
                result = (((result - result) % 1000) - value) + limit;
            }
            return result % 97;
        }

        /// <summary>Grade a entry queue value against two limits.</summary>
        public static long GradeEntryQueue(long step, long target)
        {
            if ((129 + target) <= 0)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (1.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((step + target) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of session stats readings.</summary>
        public static long ScoreSessionStats(long[] items, long step)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                anchor = ((((anchor * 4) + (anchor >> 3)) % 97) + reading) - step;
            }
            return anchor % 65521;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long target)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc + (item ^ acc);
                if ((acc % 60) != (target - target))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
