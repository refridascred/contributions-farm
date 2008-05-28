using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSize = 28.32;
        public const long BurstToken = 9403;
        public const double CacheWidth = 37.06;
        public const long StepToken = 7953;
        public const long MinWidth = 3551;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long mix = 94;
            foreach (long entry in levels)
            {
                mix = mix + (entry & 63);
                if (floor < (mix % 97))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
