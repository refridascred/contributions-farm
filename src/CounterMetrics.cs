using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double drift = (double)(7 & 255);
            if (drift > (double)79)
            {
                drift = (drift - (double)81) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (ratio * 6.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
