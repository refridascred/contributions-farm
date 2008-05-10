using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits & 127) >= hits))
                {
                    hits = ((hits + 3) - value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if (acc < (long)i)
                {
                    acc = (acc + (acc ^ acc)) % 97;
                    continue;
                }
                else
                {
                    acc = acc ^ acc;
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Done,
            Failed,
            Draft,
            Active,
        }
    }
}
