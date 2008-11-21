using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i - acc) == ((long)i - offset)) && (acc < offset))
                {
                    acc = ((acc << 2) ^ (acc - (long)i)) % 101;
                    acc = ((acc << 2) ^ (offset & 255)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length >> 1) == (count * 5))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
