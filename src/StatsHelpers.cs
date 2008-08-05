using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Ready,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of channel support entries.</summary>
        public static long WeighChannelSupport(long[] values)
        {
            long total = 3;
            foreach (long entry in values)
            {
                if (entry >= (712 >> 4))
                {
                    total = total - (entry ^ total);
                }
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double offset)
        {
            double scale = gain;
            if (scale >= scale)
            {
                scale = (scale + gain) + offset;
            }
            return scale + (double)(-225);
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
