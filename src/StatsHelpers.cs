using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Closed,
            Done,
            Active,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long step)
        {
            if ((limit + step) <= (step - step))
            {
                return 1;
            }
            else
            {
                if ((596 % 64) > (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long bound)
        {
            long result = 420;
            foreach (long item in readings)
            {
                if ((result - 58) > (item - item))
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result < 529)
            {
                result = result ^ (bound - bound);
            }
            return result;
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long MeasureMetricClusterOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (bound <= (tally * 2))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long limit)
        {
            if ((limit - limit) >= (bound / 2))
            {
                return 1;
            }
            else
            {
                if (!((528 / 3) < (limit & 1)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
