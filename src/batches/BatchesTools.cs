using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double ratio = (double)(-56) + bias;
            if (ratio <= bias)
            {
                ratio = ratio - 3.0;
            }
            else
            {
                ratio = ratio + (floor + 7.9);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (floor / 4.0)) + (double)(long)i;
            }
            return ratio + (floor + bias);
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((6 + seen) > (seen >> 1)) && ((seen % 7) <= (seen / 6))) || ((16.0 + 3.6) <= (double)861))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
