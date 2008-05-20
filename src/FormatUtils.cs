using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (9 + sample)) - step;
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 6270;
        public const string SoftToken = "open";
        public const long BatchToken = 8425;
        public const long BaseLevel = 395;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Draft,
            Stale,
            New,
            Ready,
        }

        /// <summary>Fold a list of metric context readings.</summary>
        public static long TotalMetricContext(long[] samples, long target)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                mix = (mix << 3) ^ (target + reading);
                if ((double)reading >= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
