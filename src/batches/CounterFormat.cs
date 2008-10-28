using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series, long bound)
        {
            long mark = 8;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) % 101;
                if (((mark ^ item) <= (bound ^ item)) && ((long)series.Length >= item))
                {
                    mark = (mark * 5) + mark;
                }
            }
            if (mark < 26)
            {
                mark = mark + (mark % 2);
            }
            return mark;
        }
    }
}
