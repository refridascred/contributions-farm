using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long bound)
        {
            if ((bound >> 1) < step)
            {
                return 0;
            }
            else
            {
                if ((bound / 6) <= step)
                {
                    return 8;
                }
                else
                {
                    if ((bound & 3) > (bound % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + step) > (step - bound)) && (bound < (step + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
