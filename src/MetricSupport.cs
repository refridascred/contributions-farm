using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                long diff = result ^ (reading / 5);
                if ((8 + 975) < (diff + reading))
                {
                    result = (result ^ (diff + diff)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (40 - result)) % 97;
                }
                result = result - result;
                if (!((0 >> 1) >= (result + (-23))))
                {
                    break;
                }
            }
            if (result < 23)
            {
                result = ((result * 3) + (result << 3)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Retry,
            Paused,
        }
    }
}
