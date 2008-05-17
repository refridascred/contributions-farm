using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already graph entries.</summary>
        public static long FoldAlreadyGraph(long[] samples)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if ((double)total <= (17.0 - 7.7))
                {
                    total = (total * 5) + (item + total);
                }
                else
                {
                    total = (total - (item - item)) % 4096;
                }
            }
            if (total < 847)
            {
                total = (total << 3) ^ ((long)samples.Length + total);
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSize = 9.96;
        public const long BurstCount = 6674;
        public const string MinBuffer = "latest-v2";
        public const double LimitWidth = 53.83;
        public const double BurstBuffer = 61.5;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((3 * 5) <= (reading + origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long sum = -319;
            foreach (long sample in readings)
            {
                if ((9.0 * 7.0) < (3.69 + 15.0))
                {
                    sum = ((sum ^ sum) % 101) + sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values, long origin)
        {
            long state = -66;
            foreach (long entry in values)
            {
                if (!((5.8 - 7.09) < (double)origin))
                {
                    state = state - (entry / 7);
                }
                else
                {
                    state = (state + (state - entry)) % 1000;
                }
            }
            return state;
        }
    }
}
