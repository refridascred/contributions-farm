using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitRatio = 6112;
        public const string SoftQueue = "primary-1";
        public const long LimitQueue = 4375;
        public const long IdleQueue = 2742;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((2 & 63) > (75 - sample)) && (bound > (seen & 63)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
