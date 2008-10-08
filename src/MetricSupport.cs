using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context token readings against a rule.</summary>
        public static long TallyContextTokenOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits < (hits & 63))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two farm notes measurements.</summary>
        public static double SmoothFarmNotes(double bias, double floor)
        {
            double ratio = floor / 2.0;
            if (ratio >= 3.0)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (ratio / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
