using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter support entries.</summary>
        public static long DigestCounterSupport(long[] series, long target)
        {
            long score = 0;
            foreach (long datum in series)
            {
                score = ((score + target) % 65521) - datum;
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics batches value from a seed.</summary>
        public static long SeriesMetricsBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
