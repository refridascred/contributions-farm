using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 3045;
        public const long StepGraph = 949;
        public const long BurstDepth = 9775;
        public const long SoftSpan = 2136;
        public const long LimitGraph = 2009;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.0 * 5.81) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of payload schema readings.</summary>
        public static long PairPayloadSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
