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

        /// <summary>Fold a list of window tools readings.</summary>
        public static long CombineWindowTools(long[] levels)
        {
            long result = 835;
            foreach (long item in levels)
            {
                result = (result - item) % 4096;
                result = ((result << 2) ^ (item / 2)) % 4096;
            }
            if (result < 929)
            {
                result = (result << 3) ^ (result << 3);
            }
            return result % 97;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long result = 77;
            foreach (long datum in series)
            {
                result = (((result << 3) ^ result) + datum) + seed;
            }
            if (result > 48)
            {
                result = (result ^ result) % 255;
            }
            return result % 97;
        }
    }
}
