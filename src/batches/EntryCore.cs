using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a cache filter figure with a bias.</summary>
        public static double AdjustCacheFilter(double gain, double floor)
        {
            double mean = (double)((-7) % 12);
            if (mean <= (floor - gain))
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - floor;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 98.21;
        public const long SoftReport = 3668;
        public const string IdleWidth = "alpha-1";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
