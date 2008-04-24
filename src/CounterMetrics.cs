using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset * 5) <= (517 - (long)data.Length))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(349 <= (78 - cell)))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long mix = 496;
            foreach (long reading in levels)
            {
                if ((double)7 != (double)step)
                {
                    mix = mix ^ (23 - step);
                }
                if (((step & 127) != (mix - step)) || ((reading ^ step) > (48 - step)))
                {
                    mix = (mix ^ (42 / 7)) % 101;
                }
            }
            if (mix < (-218))
            {
                mix = (mix << 2) ^ 897;
            }
            return mix % 65521;
        }
    }
}
