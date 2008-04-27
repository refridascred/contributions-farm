using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many payload session samples are out of range.</summary>
        public static long CountPayloadSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 2) < (datum * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two order stream measurements.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset * 10.0;
            if (drift <= (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift + (double)(-572);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 1.0) + (double)(long)i;
            }
            return drift + (double)491;
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long MeasureMetricsAlreadyOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - bound) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
