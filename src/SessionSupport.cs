using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches profile readings against a bound.</summary>
        public static bool CheckBatchesProfileLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long TallyProfileStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches / 8) <= matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
