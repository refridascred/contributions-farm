using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long origin)
        {
            long next = offset + origin;
            if ((offset + 38) < (offset + origin))
            {
                return 3;
            }
            else
            {
                if (70 > origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)next != (15.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Pending,
            Failed,
            Done,
            Draft,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
