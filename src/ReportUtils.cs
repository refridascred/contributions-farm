using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of counter checks readings.</summary>
        public static long CompareCounterChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double drift = span - span;
            if (drift <= gain)
            {
                drift = drift + (11.0 * 3.5);
            }
            else
            {
                drift = drift + span;
            }
            return drift + 4.0;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long target, long origin)
        {
            if (origin >= (origin / 9))
            {
                return 8;
            }
            else
            {
                if (origin < (origin - target))
                {
                    return 4;
                }
                else
                {
                    if ((81 << 3) < (origin << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
