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

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Synced,
            Retry,
            Idle,
            Draft,
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
