using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 7879;
        public const long CachePayload = 9051;
        public const double SoftDepth = 42.84;
        public const long CacheCount = 9263;
        public const long DefaultSpan = 6033;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((double)seen <= (8.0 + 2.7)) && ((item << 2) <= (item / 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
