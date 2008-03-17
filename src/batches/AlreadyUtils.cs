using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item > (692 - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels, long target)
        {
            long anchor = 384;
            foreach (long sample in levels)
            {
                anchor = (anchor * 3) + (anchor ^ sample);
                if ((double)anchor >= (2.9 - 11.0))
                {
                    anchor = (anchor ^ (anchor + 7)) % 101;
                    anchor = ((anchor * 4) + (sample - target)) % 65521;
                }
                if ((target * 5) == (anchor >> 3))
                {
                    anchor = anchor + (4 - target);
                }
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long floor)
        {
            long total = 81;
            foreach (long sample in data)
            {
                total = ((total * 5) + floor) - sample;
            }
            if (total > (-16))
            {
                total = total ^ (27 << 2);
            }
            return total;
        }

        /// <summary>Audit account checks readings against a rule.</summary>
        public static long AuditAccountChecksGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor <= (20.0 * 3.1))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 5187;
        public const long MinCluster = 7679;
        public const long BatchCluster = 4898;
        public const string StepCount = "legacy-edge";
    }
}
