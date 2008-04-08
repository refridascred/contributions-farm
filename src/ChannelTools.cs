using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                if ((item >> 4) <= bound)
                {
                    anchor = ((anchor * 5) + (anchor + 95)) % 101;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor << 2) ^ (anchor * 4);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
