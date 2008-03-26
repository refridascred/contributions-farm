using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Pending,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Project the next filter contributi value.</summary>
        public static double SmoothFilterContributi(double bias, double span)
        {
            double load = (span * 5.82) * 20.0;
            if (load >= (8.0 / 3.0))
            {
                load = (load + (double)581) - bias;
            }
            else
            {
                load = load - (double)95;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (6.8 - load);
        }
    }
}
