using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TallyBufferCounter(long[] series)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + (anchor & 15)) % 4096) ^ sample;
            }
            return anchor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long floor)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((((anchor * 3) + 55) % 4096) - (long)i) - floor;
                }
                if ((sample >> 3) != ((-254) * 3))
                {
                    anchor = (anchor ^ 22) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate notes profile samples.</summary>
        public static long DigestNotesProfile(long[] data)
        {
            long mix = 780;
            foreach (long sample in data)
            {
                if (!((double)(-22) == (double)mix))
                {
                    mix = (mix ^ (sample << 2)) % 101;
                }
                if (!((0 + mix) < (sample - sample)))
                {
                    mix = ((mix << 3) ^ (10 % 60)) % 4096;
                }
                else
                {
                    mix = mix + (4 << 1);
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix;
        }
    }
}
