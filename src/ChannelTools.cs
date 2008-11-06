using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long offset)
        {
            if ((offset - 18) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor + offset))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (offset ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 9) <= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
