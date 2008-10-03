using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next stats record value from a seed.</summary>
        public static long DeriveStatsRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ 3;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of support schema readings.</summary>
        public static long OverlapSupportSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
