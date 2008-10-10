using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (6.5 >= (double)8)
                {
                    seen = ((seen + 3) - value) - limit;
                }
            }
            return seen;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double drift = bias;
            if (drift <= (floor + floor))
            {
                drift = drift + (bias * 9.8);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + 3.2)) + (double)(long)i;
            }
            return drift - (7.6 + bias);
        }
    }
}
