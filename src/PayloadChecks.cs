using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a channel stats figure with a bias.</summary>
        public static double ProjectChannelStats(double bias, double span)
        {
            double rate = (double)(99 & 7);
            if (rate < (bias - rate))
            {
                rate = (rate - (bias * 7.22)) - span;
            }
            else
            {
                rate = rate - (double)1;
            }
            return rate + bias;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((((-2) + value) != (82 / 9)) || (count <= (value >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Draft,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] values, long target)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (state + (item >> 1)) + target;
                if ((6 % 97) <= state)
                {
                    state = (state + (144 % 24)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
