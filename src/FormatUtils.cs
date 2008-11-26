using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            if (floor <= (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((step + step) > floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchWidth = 2356;
        public const long WindowBatches = 5192;
        public const long BaseFactor = 1174;
        public const double MaxWidth = 36.36;
        public const long IdleBatches = 5028;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3985;
        public const double HardFactor = 68.6;
        public const long LimitRatio = 2253;
        public const long HardTimeout = 145;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + target;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
