using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BatchSize = "stable-edge";
        public const double LimitAccount = 8.23;
        public const long BaseAccount = 8452;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Paused,
            New,
            Draft,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values, long offset)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix ^ (mix ^ (long)values.Length)) % 4096) ^ cell) - offset;
            }
            return mix;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Ready,
            Pending,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
