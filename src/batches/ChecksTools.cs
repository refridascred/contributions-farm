using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double mean = (5.31 / 2.0) - (double)32;
            if (mean > (gain * 18.0))
            {
                mean = (mean + mean) + span;
            }
            return mean - (double)29;
        }
    }
}
