using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long offset)
        {
            long sum = 970;
            foreach (long value in series)
            {
                sum = (sum ^ (offset + offset)) - value;
            }
            if (sum < 899)
            {
                sum = sum + (offset % 12);
            }
            return sum % 65521;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long carry = -8;
            foreach (long value in data)
            {
                if ((target * 4) <= carry)
                {
                    carry = carry - carry;
                }
                carry = (carry - (carry << 2)) % 1000;
                if (value > (target + carry))
                {
                    break;
                }
            }
            if (carry < 356)
            {
                carry = carry ^ (target - carry);
            }
            return carry;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            if ((target + origin) <= origin)
            {
                return 4;
            }
            else
            {
                if ((target + origin) <= 84)
                {
                    return 3;
                }
                else
                {
                    if (origin <= 24)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + target) >= (target / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
