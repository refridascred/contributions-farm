using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long floor)
        {
            if (((floor % 24) > (origin + floor)) && ((double)floor >= (double)214))
            {
                return 7;
            }
            else
            {
                if ((origin - floor) != (172 / 7))
                {
                    return 3;
                }
                else
                {
                    if (!((96 - origin) > floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (7.4 * 12.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
