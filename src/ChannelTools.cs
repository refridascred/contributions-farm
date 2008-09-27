using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank payload metric input into a small class.</summary>
        public static long GradePayloadMetric(long origin, long offset)
        {
            if (((63 - origin) > (offset ^ offset)) && ((827 - offset) <= (offset + offset)))
            {
                return 6;
            }
            else
            {
                if ((offset / 7) > (offset / 6))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 4) <= (3 ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            New,
            Stale,
            Done,
        }
    }
}
