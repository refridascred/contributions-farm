using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = span;
            if (load < 14.0)
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load + 8.9;
            }
            return load - load;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitDepth = 86.84;
        public const long LimitToken = 8863;
        public const string MinToken = "standard-v2";
        public const long StepToken = 7543;
        public const long BaseToken = 2702;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a farm context counter forward.</summary>
        public static long IterateFarmContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (offset + offset)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
