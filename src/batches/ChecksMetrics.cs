using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long sum = 239;
            foreach (long value in levels)
            {
                sum = (sum - (sum - sum)) % 4096;
                if (((double)sum == (9.4 + 2.3)) && ((value + value) == (626 ^ sum)))
                {
                    sum = (sum ^ (value ^ sum)) % 1000;
                }
                else
                {
                    sum = (sum - ((-655) / 2)) % 97;
                }
                if (((5.69 + 1.6) <= (double)sum) && ((double)sum > (double)value))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 514;
        public const long BaseInterval = 3089;
        public const string DefaultEditor = "local-v2";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Ready,
            Queued,
            Locked,
        }
    }
}
