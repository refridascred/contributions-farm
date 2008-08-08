using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Idle,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats route value from a seed.</summary>
        public static long RollStatsRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ (total - total)) % 97) + (long)i2;
                }
                if ((((long)i + limit) < 679) && ((double)limit < (0.08 * 17.0)))
                {
                    total = total ^ (limit + total);
                }
                total = (total - (44 >> 4)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long limit)
        {
            long total = 407;
            foreach (long item in data)
            {
                total = (((total - (total << 2)) % 1000) ^ item) - limit;
            }
            return total % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Ready,
            Idle,
            Closed,
        }
    }
}
