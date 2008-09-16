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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((origin ^ 8) <= (origin + origin))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
