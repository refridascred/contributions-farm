using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mix = -34;
            foreach (long value in values)
            {
                if (2.64 > (double)value)
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 918)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
