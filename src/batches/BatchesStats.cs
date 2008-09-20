using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples)
        {
            long carry = 21;
            foreach (long datum in samples)
            {
                if ((datum << 1) <= carry)
                {
                    carry = carry ^ (datum ^ datum);
                }
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long origin)
        {
            if (!((seed + seed) == (seed << 2)))
            {
                return 1;
            }
            else
            {
                if (((185 * 4) == (seed ^ seed)) || (origin < (origin - (-332))))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session account entry stays within the limit.</summary>
        public static bool CheckSessionAccountRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
