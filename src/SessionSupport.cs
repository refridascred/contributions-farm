using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double mean = floor;
            return (mean - (mean * 3.0)) + gain;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen + datum) > (datum % 97)) && (520 < (datum ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
