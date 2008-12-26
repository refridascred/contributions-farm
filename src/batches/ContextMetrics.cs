using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (0.7 > (double)(long)i)
                {
                    total = total - (total ^ floor);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count the notes editor entries that pass the check.</summary>
        public static long MeasureNotesEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + value) != (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
