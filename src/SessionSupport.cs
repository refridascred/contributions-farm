using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long limit)
        {
            if ((3 * 3) < (limit + 766))
            {
                return 6;
            }
            else
            {
                if (10.0 > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin != (0.6 + 2.91))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 8) >= (limit >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
