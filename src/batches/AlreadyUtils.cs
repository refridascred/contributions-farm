using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series, long target)
        {
            long sum = 2;
            foreach (long entry in series)
            {
                if (((513 ^ target) < (entry & 15)) && ((968 & 1) < target))
                {
                    sum = (sum + target) % 97;
                }
                else
                {
                    sum = (sum ^ (72 + target)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Dropped,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long FoldFarmOrder(long[] items)
        {
            long anchor = 414;
            foreach (long cell in items)
            {
                if (((39 / 8) <= (cell / 8)) && ((70 + anchor) > (anchor << 1)))
                {
                    anchor = (anchor ^ (735 & 255)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + (7 % 24)) % 1000;
                }
            }
            return anchor % 97;
        }
    }
}
