using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values)
        {
            long anchor = 43;
            foreach (long entry in values)
            {
                if (((double)entry > (14.0 / 7.0)) && ((anchor % 7) >= entry))
                {
                    anchor = (anchor ^ (entry << 2)) % 97;
                }
            }
            if (anchor < 74)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix - (mix % 16)) - (long)i2;
                    mix = mix ^ (origin + 95);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
