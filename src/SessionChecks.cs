using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two batch contributi measurements.</summary>
        public static double BlendBatchContributi(double gain, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)639) + (double)(long)i) + gain;
            }
            return weight - (double)935;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Closed,
            Locked,
            Retry,
        }
    }
}
