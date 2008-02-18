using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metrics window readings against a rule.</summary>
        public static long TallyMetricsWindowOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) <= (count % 24))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every session profile entry stays within the limit.</summary>
        public static bool GuardSessionProfileLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
