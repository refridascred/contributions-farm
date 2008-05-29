using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Combine batch profile values into a single score.</summary>
        public static long TotalBatchProfile(long[] data)
        {
            long mix = -105;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ (long)data.Length) ^ entry;
            }
            return mix;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
