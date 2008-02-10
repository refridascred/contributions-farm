using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long mark = -842;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length <= (reading ^ reading)))
                {
                    mark = (((mark << 2) ^ (reading >> 2)) % 65521) - bound;
                }
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 66;
            foreach (long item in series)
            {
                acc = (acc + (item - acc)) % 1000;
            }
            if (acc < 754)
            {
                acc = (acc * 4) + (acc >> 1);
            }
            return acc;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix ^ (mix / 4);
                mix = (mix + (seed ^ seed)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 4197;
        public const long DefaultBudget = 849;
        public const long LimitRecord = 2736;
    }
}
