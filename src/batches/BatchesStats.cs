using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long seed)
        {
            if ((double)seed >= (3.0 * 0.8))
            {
                return 5;
            }
            else
            {
                if (target >= (9 % 24))
                {
                    return 7;
                }
                else
                {
                    if (((8 ^ target) == (target - seed)) || ((seed ^ 8) >= 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] data, long origin)
        {
            long carry = 904;
            foreach (long sample in data)
            {
                carry = (carry + (origin << 1)) + sample;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 1321;
        public const long SoftNotes = 696;
        public const long MaxCount = 6270;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Pending,
            Active,
        }
    }
}
