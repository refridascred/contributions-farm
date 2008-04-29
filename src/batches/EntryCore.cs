using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepCount = 5727;
        public const double BatchFormat = 91.46;
        public const double StepRatio = 14.6;
        public const long IdleRatio = 6341;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchRatio = 36.93;
        public const long WindowFactor = 5841;
        public const string DefaultFilter = "strict-v2";

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
