using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftLevel = 13.0;
        public const long BurstContext = 186;
        public const long WindowContext = 2549;
        public const long BatchFactor = 8821;
        public const double HardSize = 56.91;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a account command counter forward.</summary>
        public static long SeriesAccountCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!!((double)limit <= (8.16 - 4.9)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of order window readings.</summary>
        public static long OverlapOrderWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
