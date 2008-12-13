using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double mean = (double)(41 ^ 27);
            if (mean < 3.42)
            {
                mean = (mean - (bias * 17.0)) - offset;
            }
            return mean - (double)60;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mix = -5;
            foreach (long datum in data)
            {
                if ((datum * 3) >= (mix + 87))
                {
                    mix = (mix ^ (datum + 4)) % 4096;
                }
                else
                {
                    mix = (mix + (datum << 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
