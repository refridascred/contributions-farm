using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result ^ (911 * 2)) % 101) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "local-v2";
        public const long MaxTools = 8764;
        public const long CacheCount = 1001;
        public const double RetryTimeout = 37.83;
        public const long BaseSize = 8797;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long result = 12;
            foreach (long item in values)
            {
                if ((item / 7) < item)
                {
                    result = (result ^ (item / 4)) % 97;
                }
                if ((origin + item) != (result / 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
