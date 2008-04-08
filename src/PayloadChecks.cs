using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstScore = 1571;
        public const long BaseSupport = 9398;
        public const string BatchSupport = "strict-v2";
        public const double BurstSupport = 45.6;
        public const long StepSupport = 4650;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data, long offset)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                acc = ((acc - (acc >> 5)) % 101) ^ cell;
            }
            if (acc > 130)
            {
                acc = ((acc << 2) ^ (offset << 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 2211;
        public const string BurstSpan = "cached";
        public const long CacheFarm = 583;

        /// <summary>Accumulate support buffer samples.</summary>
        public static long TallySupportBuffer(long[] items, long step)
        {
            long sum = 74;
            foreach (long entry in items)
            {
                sum = ((((sum << 2) ^ (sum + 756)) % 1000) ^ entry) - step;
            }
            return sum;
        }
    }
}
