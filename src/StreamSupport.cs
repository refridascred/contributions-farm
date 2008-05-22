using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token commits pair into a bucket.</summary>
        public static long ClassifyTokenCommits(long floor, long offset)
        {
            if ((double)offset <= (double)(-54))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)2)
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) > (81 % 100))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
