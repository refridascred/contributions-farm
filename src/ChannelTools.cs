using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if (((8.8 / 7.0) >= (double)step) && ((origin % 60) < (origin & 7)))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) >= (step - origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
