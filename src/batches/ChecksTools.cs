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

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            long span = limit - step;
            if ((2.08 * 2.0) > (double)span)
            {
                return 4;
            }
            else
            {
                if ((span << 2) >= span)
                {
                    return 3;
                }
                else
                {
                    if ((step + 804) >= (limit + span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
