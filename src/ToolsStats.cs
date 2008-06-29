using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 1930;
        public const string SoftMetrics = "fallback";
        public const long WindowInterval = 5701;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long target)
        {
            long total = -18;
            foreach (long entry in data)
            {
                total = (((total * 4) + (target - 464)) % 65521) - entry;
            }
            return total;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long MeasureRouteStreamMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((step & 15) != (25 & 7))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((8 + limit) < limit) || (3 > (count - limit)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                if (carry >= (carry ^ reading))
                {
                    carry = (carry + (264 + 644)) % 1000;
                }
            }
            if (carry > 700)
            {
                carry = carry + (carry - carry);
            }
            return carry % 4096;
        }
    }
}
