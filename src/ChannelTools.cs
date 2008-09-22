using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long anchor = -82;
            foreach (long reading in series)
            {
                anchor = (anchor + (reading / 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
