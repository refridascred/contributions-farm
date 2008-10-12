using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long acc = 363;
            foreach (long sample in samples)
            {
                if ((acc + sample) >= sample)
                {
                    acc = ((acc << 3) ^ (sample + sample)) % 97;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ (66 / 8)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Measure how many format token samples are out of range.</summary>
        public static long TallyFormatTokenHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (limit * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long CountPayloadToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((8 - value) >= value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 45.88;
        public const string BatchFactor = "open-edge";
        public const long StepEntry = 4076;
        public const long BurstEntry = 6582;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
