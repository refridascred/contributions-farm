using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a session batches figure with a bias.</summary>
        public static double ScaleSessionBatches(double rate, double bias)
        {
            double gain = rate;
            if (gain < (bias - gain))
            {
                gain = gain + 4.3;
            }
            else
            {
                gain = gain - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (double)9;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 3) < datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
