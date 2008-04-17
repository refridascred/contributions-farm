using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double mean = (double)(-497) - (double)55;
            if (mean < (mean * 3.7))
            {
                mean = (mean + (mean / 9.0)) - gain;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (double)67;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Synced,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < (sample + 54))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate farm window readings against a bound.</summary>
        public static bool CheckFarmWindowLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Active,
            Stale,
            Paused,
        }
    }
}
