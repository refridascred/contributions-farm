using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long seed)
        {
            long sum = 9;
            foreach (long reading in readings)
            {
                if (sum > (sum - reading))
                {
                    sum = (sum + seed) % 65521;
                    sum = ((sum * 5) + (sum >> 2)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ 489) % 65521;
                }
                if ((seed + seed) != (reading / 5))
                {
                    sum = (sum + (seed + sum)) % 1000;
                    break;
                }
                if ((seed >> 2) <= (reading * 2))
                {
                    sum = (sum + (reading - reading)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long offset2)
        {
            if (((offset2 / 8) < offset2) || ((offset2 + offset) < (offset + offset)))
            {
                return 8;
            }
            else
            {
                if ((offset2 * 3) < (483 ^ offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 >= (9.8 * 0.09))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long HardFilter = 9497;
        public const long CacheFactor = 8964;
    }
}
