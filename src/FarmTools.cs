using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double ratio = (double)((-88) - (-7));
            if (ratio > (5.0 * 1.0))
            {
                ratio = (ratio + span) - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 3.0)) - (double)(long)i;
            }
            return ratio + (double)436;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Idle,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen << 1) > (seen << 3))
                {
                    seen = ((seen + 1) ^ datum) - step;
                }
            }
            return seen;
        }
    }
}
