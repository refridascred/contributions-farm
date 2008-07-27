using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 1991;
        public const long StepPayload = 6158;
        public const double MinRatio = 94.81;
        public const long RetrySpan = 9187;
        public const double WindowPayload = 77.9;

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double drift = (double)27 / 7.0;
            if (drift >= (bias * 4.07))
            {
                drift = (drift - 9.0) + ratio;
            }
            return drift + drift;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((-953) < (tally * 4))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double load = (double)(90 + 179);
            if (load <= (offset + load))
            {
                load = (load + offset) - rate;
            }
            return load + (double)433;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Closed,
        }
    }
}
