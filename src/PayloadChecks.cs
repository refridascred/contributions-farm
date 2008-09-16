using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double ratio = (rate / 6.0) + (double)(-6);
            if (ratio < (double)4)
            {
                ratio = ratio + (span / 3.0);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (double)63;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long offset)
        {
            if (((double)offset < (double)limit) && ((offset + offset) > (offset << 1)))
            {
                return 8;
            }
            else
            {
                if ((limit + offset) <= (offset >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 1) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long AuditChannelCommandOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!!((tally - tally) >= (offset & 255)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
