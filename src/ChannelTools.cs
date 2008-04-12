using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up graph profile samples.</summary>
        public static long CompareGraphProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session batch readings against a rule.</summary>
        public static long MeasureSessionBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((-889) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
