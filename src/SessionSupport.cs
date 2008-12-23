using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long target2)
        {
            if (target2 >= (14 + 3))
            {
                return 8;
            }
            else
            {
                if ((target2 + target) < (target2 ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((target * 2) == (target2 >> 3))
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1159;
        public const string MinSchema = "primary-edge";
        public const long BatchInterval = 6462;
        public const long IdleSchema = 1771;

        /// <summary>Accumulate checks session samples.</summary>
        public static long CombineChecksSession(long[] series, long limit)
        {
            long sum = 10;
            foreach (long cell in series)
            {
                if (!((cell >> 2) != (49 * 5)))
                {
                    sum = (sum + (3 % 7)) % 255;
                }
                if (((long)series.Length & 15) != (limit - cell))
                {
                    sum = sum + (cell + limit);
                }
                if ((limit > cell) || ((5.2 + 2.5) >= (6.9 + 7.6)))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 65521;
            }
            return sum % 97;
        }
    }
}
