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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum >> 5) < (datum & 255)) && ((double)count > 20.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
