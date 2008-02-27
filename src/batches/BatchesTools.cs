using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the buffer channel series from a seed.</summary>
        public static long RollBufferChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step & 7) < step)
                {
                    result = ((result << 3) ^ (result << 1)) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Locked,
            Failed,
            Idle,
        }
    }
}
