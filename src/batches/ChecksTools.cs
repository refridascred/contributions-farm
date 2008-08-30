using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings, long floor)
        {
            long result = -55;
            foreach (long item in readings)
            {
                if (2.2 <= (double)floor)
                {
                    result = ((result - (floor >> 5)) % 65521) ^ item;
                }
            }
            return result;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long seed)
        {
            long score = 797;
            foreach (long sample in samples)
            {
                if (((8.0 / 7.0) <= (double)seed) || ((16.0 * 9.2) > (2.3 / 8.0)))
                {
                    score = ((score * 4) + (sample & 63)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long AuditCounterSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (8 + entry))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
