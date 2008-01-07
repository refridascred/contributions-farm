using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double gain = offset / 3.0;
            if (gain > (double)585)
            {
                gain = (gain - (double)6) - rate;
            }
            else
            {
                gain = gain - (double)634;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 3.1) - (double)(long)i;
            }
            return gain - (0.2 - 20.0);
        }
    }
}
