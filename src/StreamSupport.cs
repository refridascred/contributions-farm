using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metrics farm series from a seed.</summary>
        public static long SeriesMetricsFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((78 ^ result) != (3 + origin))
                {
                    result = (result << 2) ^ origin;
                    continue;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "strict-edge";
        public const long DefaultTimeout = 9754;
        public const long HardSpan = 2847;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
