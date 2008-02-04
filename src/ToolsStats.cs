using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long CountChannelRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) == (item - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 5824;
        public const long BatchTimeout = 4937;
        public const string WindowSpan = "staging-1";
        public const string MinLayout = "cached-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 5105;
        public const double WindowFarm = 29.07;
        public const string StepInterval = "fallback-v2";

        /// <summary>Fold a list of channel report readings.</summary>
        public static long CombineChannelReport(long[] items)
        {
            long carry = 427;
            foreach (long entry in items)
            {
                carry = (carry << 2) ^ entry;
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry * 2) + (long)items.Length) - (long)i;
                }
                if ((carry & 3) >= (entry + entry))
                {
                    carry = carry ^ (entry + carry);
                }
            }
            return carry;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
