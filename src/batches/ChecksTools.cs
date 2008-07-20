using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long cur = target - limit;
            if ((target & 7) > (cur & 63))
            {
                return 2;
            }
            else
            {
                if (limit >= (738 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((cur >> 2) < cur))
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

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + (limit + (long)i);
                mix = (mix - 451) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Idle,
            New,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
