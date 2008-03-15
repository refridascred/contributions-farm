using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double gain = weight / 5.0;
            if (gain >= weight)
            {
                gain = gain - (floor + gain);
            }
            return gain + (double)965;
        }

        /// <summary>Compare every pair of counter support readings.</summary>
        public static long PairCounterSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Stale,
            Synced,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long RollToolsContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + sum) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
