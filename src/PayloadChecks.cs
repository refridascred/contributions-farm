using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double bias2)
        {
            double scale = bias2 * 5.0;
            if (scale < bias)
            {
                scale = scale - bias2;
            }
            return scale - (bias2 / 4.0);
        }

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long MeasureRecordLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) < entry) && ((8.22 / 8.0) > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Pending,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer editor figure with a bias.</summary>
        public static double SmoothBufferEditor(double weight, double floor)
        {
            double drift = 0.3;
            if (drift <= (weight + floor))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - 3.2;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)706) - (double)(long)i;
            }
            return drift + weight;
        }
    }
}
