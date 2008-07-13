using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a profile tools figure with a bias.</summary>
        public static double ScaleProfileTools(double ratio, double span)
        {
            double scale = span;
            if (scale < ratio)
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale + ratio)) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool CheckMetricsAlreadyLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream token readings against a rule.</summary>
        public static long CountStreamTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((1.1 + 9.74) <= (6.4 * 2.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Dropped,
            Stale,
        }
    }
}
