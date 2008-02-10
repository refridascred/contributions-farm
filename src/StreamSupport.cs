using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6221;
        public const long MinGraph = 4968;
        public const double MaxGraph = 48.52;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data, long step)
        {
            long mark = 33;
            foreach (long sample in data)
            {
                mark = ((((mark * 2) + 217) % 97) + sample) + step;
            }
            return mark % 97;
        }
    }
}
