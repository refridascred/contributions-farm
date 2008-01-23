using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many window context samples are out of range.</summary>
        public static long AuditWindowContextOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (7 <= ((long)data.Length & 7))
                {
                    tally = ((tally + 1) - sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double load = (bias / 6.0) * 9.46;
            return load + (gain - load);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((bound * 4) > (-51))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
