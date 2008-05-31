using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double scale = (weight + offset) / 4.0;
            if (scale >= (scale / 3.0))
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale - (scale * 4.76);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)5) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample + limit) >= (limit - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((cell >> 2) < origin) && ((origin + cell) == (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Retry,
            Dropped,
        }
    }
}
