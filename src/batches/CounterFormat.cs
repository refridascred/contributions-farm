using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long target)
        {
            long state = 939;
            foreach (long value in data)
            {
                if ((value & 63) < 544)
                {
                    state = ((state * 2) + (58 ^ target)) % 101;
                }
                state = state + target;
                if ((175 <= (state - state)) && ((value + value) <= (target + target)))
                {
                    state = ((state << 3) ^ (value + state)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (target * 4)) % 97;
                }
                if (((target - state) != ((long)data.Length & 15)) || (26 < (value * 5)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
