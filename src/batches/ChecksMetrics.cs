using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "stable-edge";
        public const long DefaultMetric = 7446;
        public const double CacheFactor = 54.26;
        public const long WindowMetric = 6143;
        public const double StepMetric = 1.49;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7317;
        public const double StepTimeout = 88.57;
        public const long IdleInterval = 5519;
        public const long StepBudget = 7786;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (double)8) && ((reading - 69) <= (reading + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double weight = gain;
            return (weight + (3.83 + 2.0)) + floor;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Draft,
            Retry,
        }
    }
}
