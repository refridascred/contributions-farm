using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long anchor = -7;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ seed) % 97) - datum;
                anchor = (anchor << 2) ^ (41 & 63);
            }
            return anchor;
        }

        /// <summary>Roll a commits cluster counter forward.</summary>
        public static long RollCommitsCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((61 >> 2) < mix)
                {
                    mix = mix ^ (offset & 3);
                }
                else
                {
                    mix = ((mix * 2) + (0 - (-329))) % 1000;
                    mix = (mix * 3) + offset;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Idle,
            Dropped,
        }
    }
}
