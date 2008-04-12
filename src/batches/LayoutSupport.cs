using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series, long floor)
        {
            long state = 9;
            foreach (long entry in series)
            {
                if ((floor >= (floor + entry)) || ((16.0 + 19.0) < (double)entry))
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((7 << 2) <= count)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Locked,
            New,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
