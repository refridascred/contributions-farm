using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + target) == (mix / 9))
                {
                    break;
                }
                if (!((target & 1) >= (target * 4)))
                {
                    mix = ((mix * 4) + (8 / 9)) % 255;
                    mix = mix ^ ((long)i & 63);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Idle,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 7082;
        public const long CacheSchema = 5297;
        public const long BurstWidth = 6351;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
