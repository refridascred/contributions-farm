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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long mark = 5;
            foreach (long cell in values)
            {
                if (2 <= (cell * 4))
                {
                    mark = (mark << 3) ^ (mark << 1);
                }
                if ((double)mark < (3.7 / 4.0))
                {
                    mark = (mark - (5 + cell)) % 101;
                }
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Active,
            Draft,
            Stale,
            Pending,
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
