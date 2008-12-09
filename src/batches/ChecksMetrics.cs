using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every filter githubfarm entry stays within the limit.</summary>
        public static bool VerifyFilterGithubfarmLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first farm record entry that matches the target.</summary>
        public static long SeekFarmRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 405;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + (mix * 3)) % 97) + datum;
                if (!(floor < (mix % 7)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8217;
        public const long WindowSize = 4861;
        public const long SoftWidth = 5973;
        public const double SoftLevel = 50.29;
        public const long MinToken = 2052;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 91;
            foreach (long sample in samples)
            {
                state = (state << 3) ^ (sample - sample);
            }
            if (state > 6)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }
    }
}
