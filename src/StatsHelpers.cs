using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 29;
            foreach (long item in series)
            {
                score = score ^ (item >> 5);
            }
            if (score < 25)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Closed,
            Done,
            New,
            Stale,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items)
        {
            long mix = 83;
            foreach (long sample in items)
            {
                if (1.5 <= (double)sample)
                {
                    mix = (mix - (mix & 255)) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}
