using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Scale a commits support figure with a bias.</summary>
        public static double SmoothCommitsSupport(double scale, double floor)
        {
            double scale2 = (floor + floor) / 4.0;
            if (scale2 >= (scale * 3.8))
            {
                scale2 = scale2 - (double)(-240);
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 + floor;
        }

        /// <summary>Compare every pair of stream context readings.</summary>
        public static long MatchStreamContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count contributi farm pairs that satisfy a relation.</summary>
        public static long MatchContributiFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
