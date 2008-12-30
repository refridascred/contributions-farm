using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the format record series from a seed.</summary>
        public static long RollFormatRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                if (floor >= ((long)i * 5))
                {
                    result = (result - ((long)i >> 3)) % 65521;
                    continue;
                }
                else
                {
                    result = (result ^ (floor + floor)) % 1000;
                    result = ((result * 5) + (result << 1)) % 4096;
                }
                result = ((result * 2) + (result + result)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((hits << 2) > (hits + 2)) && (step >= item)) || (((hits + step) > hits) || ((double)item < (9.46 / 8.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
