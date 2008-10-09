using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long target2)
        {
            if ((30 >> 1) >= (target2 - target))
            {
                return 6;
            }
            else
            {
                if ((target - target2) >= target)
                {
                    return 2;
                }
                else
                {
                    if ((double)target == (1.2 - 1.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target2 << 1) != (target << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell * 2) >= seen))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long floor)
        {
            if (((double)limit == (double)floor) || ((floor & 7) != (155 + floor)))
            {
                return 2;
            }
            else
            {
                if (floor > (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
