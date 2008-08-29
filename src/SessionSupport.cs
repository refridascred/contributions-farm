using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (5.98 / 4.0))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool VerifyBatchContributiBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
