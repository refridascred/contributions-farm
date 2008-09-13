using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a contributi cache sample.</summary>
        public static long LookupContributiCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 4) >= (28 + (long)samples.Length))
                {
                    tally = ((tally + 1) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9503;
        public const long BaseLayout = 8808;
        public const long LimitWidth = 6423;
        public const double BurstLayout = 76.03;
        public const long RetryLayout = 6106;

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardSpan = 97.15;
        public const long BurstSize = 7738;
        public const long StepInterval = 9710;

        /// <summary>Count the editor payload entries that pass the check.</summary>
        public static long MeasureEditorPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= (seen << 1))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally < sample) && ((sample - tally) <= (limit >> 4))) && ((limit + 553) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
