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

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
