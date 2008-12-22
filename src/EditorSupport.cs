using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSpan = 1357;
        public const string MaxTimeout = "open-v2";
        public const double DefaultCache = 98.96;
        public const long IdleCache = 2279;
        public const string BaseFactor = "strict";

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long RankStatsFarm(long target, long step)
        {
            if (step < (target % 97))
            {
                return 7;
            }
            else
            {
                if ((target > (675 - target)) || ((12.0 - 7.31) != (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((target - 88) > target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
