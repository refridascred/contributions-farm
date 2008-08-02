using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values)
        {
            long sum = -583;
            foreach (long sample in values)
            {
                sum = ((sum ^ (sum - sum)) % 97) ^ sample;
                sum = (sum + (780 + 0)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
