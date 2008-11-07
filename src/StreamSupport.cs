using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric payload samples.</summary>
        public static long DigestMetricPayload(long[] readings)
        {
            long mark = 984;
            foreach (long sample in readings)
            {
                mark = (mark * 4) + (sample << 2);
            }
            return mark;
        }
    }
}
