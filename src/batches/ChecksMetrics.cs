using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((5.24 - 9.95) == (double)tally))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 80;
            foreach (long item in series)
            {
                sum = (sum * 2) + (99 + sum);
                if ((sum * 3) >= (item - (-47)))
                {
                    sum = ((sum << 3) ^ (259 & 7)) % 101;
                }
                else
                {
                    sum = (sum ^ (item - item)) % 65521;
                }
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (sum % 7);
            }
            return sum % 65521;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Retry,
            New,
            Paused,
            Ready,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long target)
        {
            long mark = 71;
            foreach (long reading in readings)
            {
                if (!((double)mark != (7.11 * 12.0)))
                {
                    mark = (mark + (70 + reading)) % 255;
                }
                if (((18.0 / 8.0) == (double)reading) && ((reading + 123) <= (5 * 3)))
                {
                    mark = (mark + (target - target)) % 4096;
                }
            }
            if (mark > 627)
            {
                mark = ((mark * 2) + (target ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double load = scale;
            if (load < (scale * 6.3))
            {
                load = (load - (double)55) + floor;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (4.1 + scale)) + (double)(long)i;
            }
            return load + 9.6;
        }
    }
}
