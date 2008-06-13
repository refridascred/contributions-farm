using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long acc = 251;
            foreach (long cell in readings)
            {
                if (!((acc + limit) < cell))
                {
                    acc = acc + (limit << 2);
                }
                else
                {
                    acc = acc ^ limit;
                }
            }
            if (acc < 87)
            {
                acc = acc + (limit + acc);
            }
            return acc;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double gain = (double)7 - bias;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (gain * 17.0);
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Failed,
            Dropped,
        }
    }
}
