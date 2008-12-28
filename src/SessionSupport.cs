using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long floor)
        {
            if ((floor - floor) >= floor)
            {
                return 0;
            }
            else
            {
                if ((step + floor) > (step << 3))
                {
                    return 3;
                }
                else
                {
                    if ((1 > (step << 1)) && (step > (floor % 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step >= 7.1) || ((step / 7) > step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
