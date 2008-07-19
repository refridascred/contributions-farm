using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate channel session readings against a bound.</summary>
        public static bool VerifyChannelSessionLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Find the first already report entry that matches the target.</summary>
        public static long LookupAlreadyReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
