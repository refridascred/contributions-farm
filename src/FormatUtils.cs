using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long AuditFilterAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 97) >= seen)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double bias = (double)(59 ^ 65);
            if (bias > (9.59 + floor))
            {
                bias = bias - bias;
            }
            return bias + weight;
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
