using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ 429) <= (14 / 2))
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark << 3) ^ (mark + 97)) % 101) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
