using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a editor schema reading by value.</summary>
        public static long LookupEditorSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor / 8) != (96 << 2))
            {
                return 7;
            }
            else
            {
                if (((floor ^ 16) > floor) || ((double)910 <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
