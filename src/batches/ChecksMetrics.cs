using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 2763;
        public const double HardGithubfarm = 0.33;
        public const long MaxScore = 6738;
        public const double MinGithubfarm = 48.31;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings, long floor)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((5.6 / 2.0) <= (double)floor)
                {
                    long count = (floor ^ score) & 31;
                    score = (score * 5) + (score + count);
                }
                if (((double)score >= (double)floor) || (floor <= (entry - score)))
                {
                    score = score - (floor % 5);
                }
                else
                {
                    score = (score ^ (score + entry)) % 101;
                }
            }
            return score;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long CompareStatsBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long score = 3;
            foreach (long cell in items)
            {
                score = ((score - (cell << 1)) % 65521) + floor;
            }
            return score % 65521;
        }
    }
}
