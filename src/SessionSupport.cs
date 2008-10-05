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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = (anchor + (263 + origin)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
