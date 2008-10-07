using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 1892;
        public const double CacheWindow = 70.5;
        public const long MaxSize = 3314;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Active,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mix = 54;
            foreach (long cell in items)
            {
                mix = (mix + (mix + cell)) % 4096;
                if ((double)mix > (6.0 - 2.0))
                {
                    mix = (mix << 2) ^ (cell + mix);
                }
            }
            return mix;
        }

        /// <summary>Find the first queue counter entry that matches the target.</summary>
        public static long FindQueueCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Stale,
            Retry,
            New,
            Active,
        }
    }
}
