using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up farm contributi samples.</summary>
        public static long PairFarmContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double ratio = 6.66;
            return ((ratio - (double)8) + gain) + offset;
        }
    }
}
