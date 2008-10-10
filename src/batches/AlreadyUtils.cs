using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next counter metric value.</summary>
        public static double BlendCounterMetric(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= ratio)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (span - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((12.0 * 9.38) == (double)sample) && ((sample >> 1) < (sample - 62)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
