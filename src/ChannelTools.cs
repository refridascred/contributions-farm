using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long step)
        {
            long prev = limit ^ step;
            if ((step & 7) > (limit % 64))
            {
                return 5;
            }
            else
            {
                if ((limit >> 5) == (prev - step))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (3.36 * 7.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Locked,
            New,
            Active,
        }
    }
}
