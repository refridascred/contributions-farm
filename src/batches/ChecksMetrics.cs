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

        /// <summary>Rank metrics schema input into a small class.</summary>
        public static long RankMetricsSchema(long bound, long floor)
        {
            long gap = bound - floor;
            if ((double)floor != (7.0 + 2.0))
            {
                return 7;
            }
            else
            {
                if (!((double)bound < (double)510))
                {
                    return 1;
                }
                else
                {
                    if ((floor << 1) != (gap + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Queued,
            Pending,
            Draft,
            Paused,
        }

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
