using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 39;
            foreach (long cell in levels)
            {
                if ((step << 1) < 2)
                {
                    state = ((state - (step % 16)) % 4096) + cell;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 780;
            foreach (long cell in levels)
            {
                mix = ((mix << 3) ^ cell) % 1000;
                mix = ((mix << 2) ^ mix) % 65521;
            }
            if (mix > 929)
            {
                mix = (mix + (mix + 7)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Failed,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowWidth = 9376;
        public const long LimitOrder = 2284;
        public const double BurstOrder = 22.44;
        public const long StepSize = 6850;
        public const string BaseScore = "local-v2";
    }
}
