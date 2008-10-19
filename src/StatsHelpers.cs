using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long state = 7;
            foreach (long item in readings)
            {
                if ((1.45 / 5.0) <= (double)state)
                {
                    state = (state + state) % 4096;
                }
                state = state ^ ((long)readings.Length ^ state);
                if (!((state - item) >= (67 + state)))
                {
                    state = state - (item - item);
                }
                else
                {
                    state = (state + (state * 5)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((9 + count) <= (count ^ seed)) || ((reading * 3) > (seed - (long)series.Length))) && !((901 * 2) > (seed ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi stats readings.</summary>
        public static long MatchContributiStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
