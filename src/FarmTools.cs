using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long offset)
        {
            if ((double)814 != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((6.17 / 6.0) >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((8 % 5) < (offset * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
