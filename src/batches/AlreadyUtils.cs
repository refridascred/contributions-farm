using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + tally) != (273 + tally))
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

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double bias2 = span - (double)(-52);
            if (bias2 > bias)
            {
                bias2 = bias2 - span;
            }
            else
            {
                bias2 = bias2 + 8.0;
            }
            return bias2 + (span * 8.72);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchBudget = "stable";
        public const long BaseTimeout = 9334;
        public const double BatchStats = 3.4;

        /// <summary>Digest a series of counter command entries.</summary>
        public static long CombineCounterCommand(long[] series, long offset)
        {
            long acc = 127;
            foreach (long value in series)
            {
                if (!((offset - value) < 4))
                {
                    acc = (acc ^ 3) % 65521;
                }
                else
                {
                    acc = (acc ^ ((long)series.Length + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Iterate the format support series from a seed.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
