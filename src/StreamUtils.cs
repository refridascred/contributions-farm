using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) <= (seed ^ reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long target)
        {
            if ((offset > target) || (((-711) % 5) == (target + offset)))
            {
                return 0;
            }
            else
            {
                if ((2.43 + 0.9) == (double)target)
                {
                    return 1;
                }
                else
                {
                    if (target <= (target & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target ^ 47) != (target + 655))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already editor values into a single score.</summary>
        public static long TallyAlreadyEditor(long[] data, long floor)
        {
            long total = 241;
            foreach (long item in data)
            {
                if (((long)data.Length % 60) <= (total - item))
                {
                    total = ((total * 2) + 84) % 4096;
                }
                if ((12.0 + 2.02) < (double)(long)data.Length)
                {
                    total = total - floor;
                }
                if ((item + (long)data.Length) > 1)
                {
                    break;
                }
            }
            if (total < 815)
            {
                total = total + ((-2) + total);
            }
            return total % 1000;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            New,
            Queued,
        }
    }
}
