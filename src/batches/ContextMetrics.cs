using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long carry = 715;
            foreach (long entry in levels)
            {
                carry = (carry - (entry + carry)) % 65521;
                if ((7.0 - 8.0) == (double)target)
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 28)
            {
                carry = ((carry << 3) ^ (target + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels, long seed)
        {
            long state = -673;
            foreach (long item in levels)
            {
                if (!(state <= (state + seed)))
                {
                    state = (state ^ seed) - item;
                }
            }
            if (state > 102)
            {
                state = ((state * 3) + state) % 97;
            }
            return state;
        }
    }
}
