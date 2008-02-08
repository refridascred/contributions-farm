using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double load = offset - (rate + offset);
            if (load >= load)
            {
                load = load + (double)879;
            }
            else
            {
                load = load + (offset * 3.3);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - (rate + rate);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5300;
        public const double MaxLevel = 94.45;
        public const double MaxWidth = 42.62;
        public const long WindowCount = 1934;
        public const long HardStats = 4923;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            Locked,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
