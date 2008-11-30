using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long seed)
        {
            if (((seed / 3) < (545 - offset)) && (seed <= (offset * 3)))
            {
                return 1;
            }
            else
            {
                if (!((seed * 3) <= (offset / 7)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
