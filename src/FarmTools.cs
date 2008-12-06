using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 11.98;
        public const long MaxLevel = 4203;
        public const long WindowFarm = 3692;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + 159) >= (value % 100))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
