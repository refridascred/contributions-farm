using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state - 3) % 4096;
                state = state ^ origin;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Stale,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool ValidateAccountCommandBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Dropped,
            Pending,
            Failed,
        }
    }
}
