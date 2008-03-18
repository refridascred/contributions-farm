using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples, long bound)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 65521;
                if (bound < (mix + bound))
                {
                    mix = mix ^ (value * 2);
                }
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long mix = -61;
            foreach (long sample in values)
            {
                if ((sample + 717) == (mix + sample))
                {
                    mix = ((mix << 3) ^ (sample - 550)) - floor;
                }
            }
            return mix % 1000;
        }
    }
}
