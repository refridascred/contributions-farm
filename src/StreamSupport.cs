using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 9474;
        public const double BurstSize = 71.67;
        public const string LimitGraph = "alpha-edge";

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count schema record pairs that satisfy a relation.</summary>
        public static long OverlapSchemaRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
