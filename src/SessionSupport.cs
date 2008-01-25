using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                if ((datum <= anchor) || ((anchor * 4) >= (2 << 2)))
                {
                    anchor = (anchor + (506 / 4)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long mix = 69;
            foreach (long datum in series)
            {
                mix = (mix + seed) % 101;
                mix = (mix - (datum >> 1)) % 1000;
                mix = (mix * 2) + (7 / 3);
            }
            return mix;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
