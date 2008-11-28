using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 82.12;
        public const long LimitTimeout = 8163;
        public const double DefaultLevel = 65.81;
        public const long WindowCount = 3243;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels, long offset)
        {
            long mix = 991;
            foreach (long entry in levels)
            {
                if ((4.5 + 3.6) != (double)mix)
                {
                    mix = (((mix ^ mix) % 1000) ^ entry) + offset;
                }
            }
            return mix % 97;
        }
    }
}
