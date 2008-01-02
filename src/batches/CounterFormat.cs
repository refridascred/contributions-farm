using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (((-2) + 2) == (offset2 - edge))
            {
                return 8;
            }
            else
            {
                if ((9.17 - 1.6) < (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
