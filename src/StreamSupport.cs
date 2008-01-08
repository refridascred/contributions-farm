using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultScore = 2539;
        public const long MaxInterval = 4645;
        public const string SoftContext = "open-1";
        public const double DefaultInterval = 26.58;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 4) < 484)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long RollOrderCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
