using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 1992;
        public const long CacheAccount = 1945;
        public const string MaxAccount = "latest";
    }
}
