using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Locked,
            New,
            Failed,
            Paused,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if (((acc & 127) == (acc * 4)) || ((4 + acc) <= (item + 225)))
                {
                    acc = acc - (acc & 7);
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }
    }
}
