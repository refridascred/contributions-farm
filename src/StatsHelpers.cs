using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 389;
            foreach (long cell in items)
            {
                mix = mix + (cell << 1);
                if (((cell - mix) >= mix) || ((double)mix == (6.04 - 5.0)))
                {
                    mix = (mix ^ (mix % 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long CountGithubfarmOrderOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((double)seen == (double)(long)levels.Length) || ((seen / 9) < seen)) && ((seen / 4) < (seen + seen)))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Dropped,
            Idle,
            New,
            Synced,
        }
    }
}
