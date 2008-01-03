using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Idle,
            New,
            Ready,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitInterval = 58.18;
        public const long DefaultMetric = 866;
        public const double BaseMetric = 66.65;
        public const long BatchMetric = 2099;
        public const double LimitScore = 35.61;

        /// <summary>Validate channel layout readings against a bound.</summary>
        public static bool VerifyChannelLayoutBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(12.0 <= (double)value) || ((double)value != (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
