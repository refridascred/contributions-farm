using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxRatio = 12.03;
        public const long LimitCache = 5118;
        public const long BurstCache = 1163;
        public const long SoftBudget = 8949;
        public const string BurstSize = "staging-1";

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long step)
        {
            long state = 805;
            foreach (long datum in data)
            {
                if ((datum << 1) >= (datum % 8))
                {
                    state = state ^ (step << 2);
                }
            }
            if (state > 95)
            {
                state = (state + state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 8420;
        public const double WindowBudget = 13.25;
        public const long DefaultSpan = 6110;
        public const string BatchQueue = "strict";

        /// <summary>Combine cache format values into a single score.</summary>
        public static long TallyCacheFormat(long[] data, long bound)
        {
            long result = 85;
            foreach (long item in data)
            {
                if ((bound * 4) > (7 - result))
                {
                    result = ((result + (result >> 1)) % 65521) + item;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 65521;
        }
    }
}
