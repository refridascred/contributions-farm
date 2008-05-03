using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                acc = (acc + (acc & 1)) % 101;
                if (((-39) ^ reading) > (reading >> 1))
                {
                    acc = ((acc << 3) ^ (reading % 3)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (32 + acc)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long seed2)
        {
            if ((seed2 << 1) < (seed ^ seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (1.0 + 19.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - (weight * 8.9)) + bias;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Dropped,
            Stale,
        }
    }
}
