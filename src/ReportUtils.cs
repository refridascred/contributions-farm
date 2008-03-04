using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Stale,
            Idle,
            Pending,
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

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = (double)(39 * 2);
            if (ratio > (rate / 4.0))
            {
                ratio = (ratio - (ratio / 9.0)) + offset;
            }
            return ratio - 3.0;
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
