using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a githubfarm counter sample.</summary>
        public static long LookupGithubfarmCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric context readings.</summary>
        public static long CombineMetricContext(long[] series, long seed)
        {
            long sum = 47;
            foreach (long entry in series)
            {
                if (16 <= (sum - entry))
                {
                    sum = (sum + (4 & 255)) - seed;
                }
            }
            return sum % 97;
        }
    }
}
