using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 4991;
        public const long DefaultScore = 6557;
        public const long IdleDepth = 427;
        public const long WindowScore = 9173;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (offset >> 2)) % 1000;
                mix = (mix * 4) + offset;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long total = 63;
            foreach (long value in samples)
            {
                if (((double)total != (double)58) && (value < floor))
                {
                    total = total + (31 * 4);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Synced,
            Paused,
            Ready,
        }
    }
}
