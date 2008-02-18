using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Queued,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < value)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double rate2 = (double)(41 + 5);
            if (rate2 <= (floor - rate))
            {
                rate2 = rate2 - floor;
            }
            return rate2 + rate2;
        }
    }
}
