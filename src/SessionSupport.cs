using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long sum = -17;
            foreach (long datum in levels)
            {
                if (((double)datum > (0.41 + 9.87)) || ((sum ^ sum) <= datum))
                {
                    sum = (sum + (datum ^ datum)) % 1000;
                }
                else
                {
                    sum = sum - (datum + datum);
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 4) + (sum >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool VerifyOrderStatsRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
