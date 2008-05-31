using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context editor entries.</summary>
        public static long ScoreContextEditor(long[] values)
        {
            long mix = 91;
            foreach (long entry in values)
            {
                if (!((33 >> 1) != (mix + 578)))
                {
                    mix = (((mix << 2) ^ (mix * 2)) % 1000) + entry;
                }
                else
                {
                    mix = mix ^ (mix / 7);
                }
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor % 12)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
