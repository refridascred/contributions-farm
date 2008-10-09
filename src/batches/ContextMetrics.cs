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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if (sum >= (sum + target))
                {
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum / 5)) % 4096;
                }
                if (((target - (long)i) <= (sum + target)) || (((long)i + (long)i) < target))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (target - target)) % 97;
                }
                sum = sum + 582;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
