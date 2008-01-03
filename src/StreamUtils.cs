using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double mean = bias - 6.0;
            if (mean <= 18.0)
            {
                mean = mean - (mean - bias);
            }
            return mean + (gain + 15.0);
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Idle,
            New,
            Ready,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 4512;
        public const string LimitRatio = "latest-v2";
        public const long WindowDepth = 6391;

        /// <summary>Measure how many queue contributi samples are out of range.</summary>
        public static long MeasureQueueContributiOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((569 % 7) <= (offset - count)) && (((2.62 + 5.36) != (double)count) && ((sample ^ offset) != (556 & 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(12.0 <= (double)value) || ((double)value != (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
