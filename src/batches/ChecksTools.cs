using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a context queue pair into a bucket.</summary>
        public static long GradeContextQueue(long limit, long offset)
        {
            if (((limit + limit) <= (466 - offset)) || (limit < (offset - offset)))
            {
                return 7;
            }
            else
            {
                if ((7.5 + 7.0) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (9 <= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= 765)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long step)
        {
            long result = 427;
            foreach (long cell in readings)
            {
                if ((18.0 + 6.1) != (double)(long)readings.Length)
                {
                    result = (((result ^ (522 * 5)) % 97) + cell) + step;
                }
            }
            return result;
        }
    }
}
