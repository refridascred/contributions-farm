using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long slot = limit + step;
            if ((double)limit > (double)slot)
            {
                return 7;
            }
            else
            {
                if (!(step <= slot))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) != (slot + slot)) || ((slot + 741) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool ValidateReportRecordBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Locked,
            New,
            Queued,
            Pending,
        }
    }
}
