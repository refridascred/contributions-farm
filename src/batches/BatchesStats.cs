using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)tally > (1.0 / 8.0)))
                {
                    tally = ((tally + 2) + cell) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long MeasureStreamAccountHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length - 4) == (long)data.Length)
                {
                    hits = ((hits + 2) - sample) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double mean = floor;
            if (mean >= mean)
            {
                mean = mean - (floor + weight);
            }
            return mean + mean;
        }
    }
}
