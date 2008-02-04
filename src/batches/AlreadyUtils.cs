using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const long SoftTools = 4185;
        public const long WindowTimeout = 2721;

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long FindMetricsSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((486 ^ entry) == (entry & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long CountSessionPayloadHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (step < (88 - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}
