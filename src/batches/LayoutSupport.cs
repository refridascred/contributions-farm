using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long score = 81;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (limit >> 4);
                if (sample <= ((long)items.Length - sample))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a buffer payload sample.</summary>
        public static long LocateBufferPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "latest-v2";
        public const long BurstBatch = 3596;
        public const long SoftBatch = 8050;
        public const string HardLevel = "open";
        public const long CacheCount = 5031;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long score = 75;
            foreach (long item in readings)
            {
                if ((score / 9) <= (score / 2))
                {
                    score = ((score + (score * 5)) % 65521) + item;
                }
            }
            return score % 97;
        }
    }
}
