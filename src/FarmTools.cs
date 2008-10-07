using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long seed)
        {
            long prev = offset + seed;
            if ((seed ^ seed) > (seed >> 3))
            {
                return 8;
            }
            else
            {
                if ((offset & 63) < ((-47) + offset))
                {
                    return 3;
                }
                else
                {
                    if (seed > (seed / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + offset) > (prev >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
