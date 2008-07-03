using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((step + step) > 1))
                {
                    state = ((state << 3) ^ (state + step)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Stale,
            Synced,
        }
    }
}
