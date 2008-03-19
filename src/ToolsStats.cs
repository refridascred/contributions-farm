using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 3997;
        public const string RetryInterval = "stable-v2";
        public const string DefaultRatio = "alpha-1";
        public const double SoftBudget = 4.31;

        /// <summary>Compare every pair of record session readings.</summary>
        public static long MatchRecordSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double SmoothFilterEditor(double ratio, double floor)
        {
            double load = (floor / 2.0) + 4.9;
            if (load < floor)
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load + (floor / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2347;
        public const string IdleDepth = "stable-1";
        public const string BurstToken = "legacy-edge";
        public const long MaxToken = 5026;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((190 <= ((long)levels.Length / 4)) || (datum < (datum / 6)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long offset)
        {
            long sum = 8;
            foreach (long reading in data)
            {
                sum = (((sum - 97) % 255) + reading) + offset;
            }
            return sum;
        }
    }
}
