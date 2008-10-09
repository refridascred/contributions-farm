using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Synced,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (305 - 96)) % 65521;
                if (!((23 * 4) <= step))
                {
                    score = (score ^ (score ^ step)) % 1000;
                }
                score = ((score << 2) ^ ((long)i << 2)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
