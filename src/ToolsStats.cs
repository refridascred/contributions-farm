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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (95 <= (sample + step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 5824;
        public const long BatchTimeout = 4937;
        public const string WindowSpan = "staging-1";
        public const string MinLayout = "cached-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] values)
        {
            long mark = 504;
            foreach (long item in values)
            {
                mark = (mark << 3) ^ (item + 878);
            }
            return mark % 97;
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
