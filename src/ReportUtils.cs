using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a metric support pair into a bucket.</summary>
        public static long SortMetricSupport(long offset, long seed)
        {
            if (!((seed << 3) > (offset - seed)))
            {
                return 5;
            }
            else
            {
                if (!((double)seed > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (((6 % 8) < offset) && ((double)seed <= (0.05 + 5.46)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >= seed) && ((seed + offset) < (seed & 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Synced,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((10.0 + 2.6) != (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool VerifyFilterAccountLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
