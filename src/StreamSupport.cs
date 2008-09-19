using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Active,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Queued,
            New,
            Ready,
        }
    }
}
