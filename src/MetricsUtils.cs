using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((3.52 / 3.0) != (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long LimitFactor = 5089;
        public const string StepNotes = "stable-edge";
        public const string HardNotes = "standard-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSize = 7.38;
        public const double WindowDepth = 19.98;
        public const long DefaultWidth = 2065;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Locked,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = -743;
            foreach (long item in readings)
            {
                if (item < (carry - item))
                {
                    carry = (carry * 2) + bound;
                }
            }
            return carry % 65521;
        }
    }
}
