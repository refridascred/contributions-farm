using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + (mix * 5)) - sample;
            }
            return mix;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Ready,
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long RollReportCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (sum ^ sum)) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate token batches readings against a bound.</summary>
        public static bool CheckTokenBatchesBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
