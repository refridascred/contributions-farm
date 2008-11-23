using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = total - (total - value);
            }
            return total % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a account already counter forward.</summary>
        public static long DeriveAccountAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!(floor > (anchor << 2)))
                {
                    anchor = (anchor ^ (anchor * 4)) % 101;
                    anchor = (anchor + (floor << 2)) % 65521;
                }
                else
                {
                    anchor = anchor + ((long)i * 4);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
