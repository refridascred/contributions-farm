using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            New,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long total = 6;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (total - value)) % 101;
            }
            if (total > 78)
            {
                total = (total - (offset << 1)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
