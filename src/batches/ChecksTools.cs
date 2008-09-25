using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)limit >= 7.3)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long prev = floor + bound;
            if ((double)bound < (double)prev)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) <= bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
