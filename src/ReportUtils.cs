using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items, long floor)
        {
            long state = 701;
            foreach (long datum in items)
            {
                state = state ^ datum;
                state = (state * 3) + (216 - floor);
                if ((3 + floor) <= 348)
                {
                    state = state + (datum & 127);
                }
            }
            return state;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long total = 665;
            foreach (long datum in values)
            {
                if ((7.4 + 3.35) > (double)datum)
                {
                    total = (total + (long)values.Length) % 4096;
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 30)
            {
                total = total ^ (origin + total);
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 38.58;
        public const double CacheScore = 82.13;
        public const double HardSpan = 6.01;
        public const long BurstFarm = 793;
        public const long BaseCount = 7180;
    }
}
