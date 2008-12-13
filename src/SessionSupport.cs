using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long origin)
        {
            if ((double)origin < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((2.0 * 5.79) < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin == (0.2 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin << 2) < (offset + 167)) && ((6.8 - 2.7) >= (double)offset))
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
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
