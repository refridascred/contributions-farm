using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Active,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values, long floor)
        {
            long result = 879;
            foreach (long datum in values)
            {
                result = ((result ^ (result * 3)) + datum) + floor;
            }
            return result % 65521;
        }
    }
}
