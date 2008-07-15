using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long state = -47;
            foreach (long value in data)
            {
                state = (state + (state - state)) % 255;
                state = (state * 2) + ((long)data.Length - state);
                if ((double)value >= 9.3)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
