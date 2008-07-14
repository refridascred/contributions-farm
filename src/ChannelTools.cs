using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Idle,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Accumulate graph route samples.</summary>
        public static long ScoreGraphRoute(long[] data, long target)
        {
            long result = 86;
            foreach (long item in data)
            {
                if ((double)item >= (5.6 + 5.5))
                {
                    result = (result << 2) ^ item;
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    result = (result * 2) + ((long)i * 5);
                    result = (result - (item - target)) % 101;
                }
                result = result + target;
            }
            return result;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
