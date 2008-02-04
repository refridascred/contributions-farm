using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches - matches) <= reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long floor)
        {
            long next = limit - floor;
            if ((118 <= (limit & 3)) && ((limit ^ 39) > (floor >> 1)))
            {
                return 4;
            }
            else
            {
                if ((next - next) >= (limit & 31))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

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
