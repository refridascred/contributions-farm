using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long bound)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                if (!((datum * 3) <= datum))
                {
                    score = ((score * 3) + (long)levels.Length) % 4096;
                }
                else
                {
                    score = (score ^ (bound << 2)) % 97;
                    score = score - ((long)levels.Length % 5);
                }
                if ((double)(long)levels.Length != (3.4 / 8.0))
                {
                    score = (score + bound) % 65521;
                }
            }
            if (score < 98)
            {
                score = score + (score + bound);
            }
            return score;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
