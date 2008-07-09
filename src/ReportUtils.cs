using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset >> 3) < next)
            {
                return 6;
            }
            else
            {
                if ((offset / 4) <= step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (7.02 + 0.88))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((seed - tally) >= tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((5.2 / 2.0) < (double)origin)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Closed,
            Draft,
            Pending,
            Active,
        }
    }
}
