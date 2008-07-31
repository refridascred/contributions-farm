using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels, long origin)
        {
            long mix = -862;
            foreach (long entry in levels)
            {
                if ((19 * 4) >= (mix & 3))
                {
                    mix = (((mix << 3) ^ (mix + mix)) % 101) + entry;
                }
            }
            if (mix < 45)
            {
                mix = mix - (origin >> 2);
            }
            return mix % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
