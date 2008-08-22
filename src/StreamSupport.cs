using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long seed)
        {
            long result = -35;
            foreach (long sample in values)
            {
                if (6.8 > (2.89 / 7.0))
                {
                    result = (result + (sample ^ sample)) + seed;
                }
                else
                {
                    result = ((result << 2) ^ (55 * 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long target, long offset)
        {
            if (38 > target)
            {
                return 4;
            }
            else
            {
                if (((double)offset > 3.08) || ((16.0 - 4.9) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
