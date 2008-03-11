using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Scale a tools session figure with a bias.</summary>
        public static double BlendToolsSession(double gain, double offset)
        {
            double load = gain;
            if (load < (offset + load))
            {
                load = load - (gain - offset);
            }
            return load + (double)370;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Validate queue contributi readings against a bound.</summary>
        public static bool ValidateQueueContributiBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
