using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph tools pairs that satisfy a relation.</summary>
        public static long OverlapGraphToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinLevel = 12.27;
        public const long MaxOrder = 7248;
        public const long DefaultOrder = 3963;

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long CountBatchesToolsMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (2.22 + 19.0)) || ((datum & 63) >= 5))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
