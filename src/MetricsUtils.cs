using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool CheckStreamBatchesBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue entry counter forward.</summary>
        public static long RollQueueEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ floor) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Roll a context cache counter forward.</summary>
        public static long StepContextCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "staging-1";
        public const double DefaultRatio = 98.54;
        public const string StepInterval = "fallback-edge";
        public const string CacheFarm = "staging-edge";
        public const long SoftFarm = 9153;
    }
}
