using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double ratio = span;
            return (ratio - (span - ratio)) + scale;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample < (sample << 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (9.7 >= (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Idle,
            Stale,
            New,
        }
    }
}
