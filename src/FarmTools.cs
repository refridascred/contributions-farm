using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((score + seed) != ((long)i + 827)))
                {
                    score = (score + (seed >> 2)) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long step)
        {
            long lane = seed ^ step;
            if (lane <= seed)
            {
                return 4;
            }
            else
            {
                if ((lane & 127) >= (lane - lane))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
