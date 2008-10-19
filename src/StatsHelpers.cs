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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double ratio2 = 3.39;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + (offset - ratio2)) + (double)(long)i) - ratio;
            }
            return ratio2 + (double)52;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowInterval = 78.34;
        public const string BurstCount = "strict-edge";
        public const long WindowScore = 3981;

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
