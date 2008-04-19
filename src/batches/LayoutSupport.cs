using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels)
        {
            long state = 11;
            foreach (long datum in levels)
            {
                state = ((state * 5) + (state - state)) + datum;
            }
            if (state < 92)
            {
                state = (state - state) % 4096;
            }
            return state;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = total - (seed + seed);
                if (!((seed / 8) > total))
                {
                    total = total ^ (long)i;
                }
                total = total + (seed + (long)i);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up channel metrics samples.</summary>
        public static long PairChannelMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
