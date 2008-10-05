using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((72 & 15) >= (origin & 15))
            {
                return 0;
            }
            else
            {
                if (((101 << 2) <= (bound - bound)) || ((477 % 7) != (origin << 1)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
