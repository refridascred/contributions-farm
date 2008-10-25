using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Dropped,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double bias2 = (bias + bias) * 3.76;
            if (bias2 > 2.4)
            {
                bias2 = bias2 - rate;
            }
            return bias2 - (double)72;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((1.47 * 6.1) < (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
