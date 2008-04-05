using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 4257;
        public const long MinFactor = 4628;
        public const string WindowFarm = "strict";
        public const long BurstDepth = 7325;
        public const long SoftBudget = 4299;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long bound)
        {
            long next = target + bound;
            if ((double)bound == (double)next)
            {
                return 6;
            }
            else
            {
                if (!((6.76 + 4.0) != (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor - (-65)) <= anchor)
                {
                    anchor = anchor - (37 % 97);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate batches layout samples.</summary>
        public static long WeighBatchesLayout(long[] values, long target)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                carry = (carry ^ (target + carry)) % 65521;
                if ((target & 31) <= datum)
                {
                    carry = (carry ^ (carry << 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
