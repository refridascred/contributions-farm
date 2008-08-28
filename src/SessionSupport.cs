using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long floor)
        {
            long state = 0;
            foreach (long datum in values)
            {
                if (((7 << 2) >= (floor % 12)) && ((double)datum < (1.0 - 14.0)))
                {
                    state = state - datum;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long TotalClusterProfile(long[] levels, long step)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                result = (result ^ step) % 4096;
                if (reading > (result + step))
                {
                    result = result + (8 / 9);
                }
            }
            return result % 65521;
        }
    }
}
