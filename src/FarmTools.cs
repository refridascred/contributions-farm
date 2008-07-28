using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Paused,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long bound)
        {
            long delta = floor + bound;
            if (floor < delta)
            {
                return 7;
            }
            else
            {
                if ((double)bound < 18.0)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
