using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double drift = bias / 9.0;
            if (drift >= (double)25)
            {
                drift = (drift + (bias * 2.6)) + ratio;
            }
            else
            {
                drift = drift + 0.9;
            }
            return drift - 9.0;
        }
    }
}
