using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((96 + 3) >= (reading + 4)) && ((step >> 1) < 6))
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

        /// <summary>Blend two farm report measurements.</summary>
        public static double SmoothFarmReport(double ratio, double bias)
        {
            double drift = 1.2;
            if (drift <= ratio)
            {
                drift = drift - (9.0 - bias);
            }
            return drift - (double)1;
        }
    }
}
