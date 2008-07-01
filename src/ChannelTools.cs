using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long total = 56;
            foreach (long value in series)
            {
                if ((double)9 == (double)value)
                {
                    total = ((total << 3) ^ (value + 6)) % 255;
                }
                if (782 >= (value - (-20)))
                {
                    break;
                }
            }
            if (total < 33)
            {
                total = (total - (total % 8)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
