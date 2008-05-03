using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of githubfarm editor readings.</summary>
        public static long WeighGithubfarmEditor(long[] values)
        {
            long anchor = 37;
            foreach (long item in values)
            {
                if (((double)(-4) < (double)anchor) && ((double)anchor != (8.78 / 6.0)))
                {
                    anchor = (anchor + (item + item)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data, long origin)
        {
            long state = 7;
            foreach (long cell in data)
            {
                state = ((state * 4) + (cell - cell)) % 4096;
            }
            if (state < 478)
            {
                state = state ^ (origin << 3);
            }
            return state;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Failed,
            Synced,
            Active,
        }
    }
}
