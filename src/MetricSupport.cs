using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 429;
        public const string BurstBuffer = "alpha-v2";
        public const string HardTimeout = "strict-edge";

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = total - total;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
