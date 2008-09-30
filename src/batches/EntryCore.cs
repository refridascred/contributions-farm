using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a account schema value against two limits.</summary>
        public static long ClassifyAccountSchema(long target, long floor)
        {
            if ((14.0 / 6.0) == (double)floor)
            {
                return 8;
            }
            else
            {
                if ((6 * 4) > floor)
                {
                    return 0;
                }
                else
                {
                    if (7.0 > (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double scale = offset;
            if (scale < (weight - weight))
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - 782) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
