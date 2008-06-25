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

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
