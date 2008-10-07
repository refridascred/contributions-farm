using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double weight = bias / 7.0;
            if (weight <= rate)
            {
                weight = weight + (double)83;
            }
            return weight + bias;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleBudget = 5892;
        public const long StepTimeout = 286;
        public const double RetryNotes = 12.32;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double load = bias;
            if (load <= (load * 3.3))
            {
                load = (load - bias) - rate;
            }
            return load + load;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8325;
        public const long MinSpan = 6698;
        public const long MinWidth = 7172;
        public const string CacheFactor = "standard";
        public const long StepCount = 1846;
    }
}
