using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 3423;
        public const string BaseInterval = "local";
        public const long WindowWidth = 2253;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if (value < (result + result))
                {
                    result = (result * 3) + 9;
                }
                else
                {
                    result = (result + 961) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - ((long)i << 2)) % 101;
                mix = (mix + (long)i) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
