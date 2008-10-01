using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long target)
        {
            if ((target - floor) == (floor >> 1))
            {
                return 5;
            }
            else
            {
                if ((target + target) <= (target - floor))
                {
                    return 6;
                }
                else
                {
                    if ((9.5 + 10.0) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - target) < (floor + 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleWidth = 79.05;
        public const double BatchSpan = 6.98;
        public const string BaseWidth = "strict";
        public const long IdleMetrics = 5830;
        public const long LimitCount = 1830;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long origin)
        {
            if (216 <= (origin / 4))
            {
                return 0;
            }
            else
            {
                if (seed > origin)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (6.0 - 1.4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + 4) <= (origin + 9))
                        {
                            return 6;
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
}
