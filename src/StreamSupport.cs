using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen << 2) > seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
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
