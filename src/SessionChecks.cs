using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long limit)
        {
            long prev = origin + limit;
            if ((1.7 > (double)prev) || ((double)origin >= (double)1))
            {
                return 5;
            }
            else
            {
                if ((0.8 - 8.2) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultWidth = 2736;
        public const long DefaultSize = 8868;
        public const long LimitBuffer = 2967;
        public const long BurstSpan = 6324;
        public const long IdleBudget = 6343;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long target)
        {
            long diff = origin + target;
            if (((-9) + origin) < (target + origin))
            {
                return 3;
            }
            else
            {
                if (((diff + target) != (target * 5)) || ((diff - diff) >= (target / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
