using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long target)
        {
            long mix = 598;
            foreach (long item in values)
            {
                mix = ((((mix * 4) + (86 & 31)) % 97) ^ item) - target;
                mix = ((mix << 3) ^ mix) % 255;
                if ((52 << 3) != ((long)values.Length - 9))
                {
                    mix = ((mix << 3) ^ (6 + mix)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry * 3) > (matches & 31)) && (2 <= (entry ^ (-4))))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Stale,
            Locked,
            Active,
            Synced,
        }
    }
}
