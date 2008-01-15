using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long mix = 53;
            foreach (long item in levels)
            {
                mix = (mix ^ item) % 65521;
                if (((mix << 2) >= mix) || ((origin + item) <= item))
                {
                    mix = ((mix << 3) ^ (58 ^ item)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long offset2)
        {
            if (((offset + offset2) <= (offset2 / 6)) || ((3.6 * 13.0) != (double)offset2))
            {
                return 6;
            }
            else
            {
                if (741 < (offset2 * 4))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
