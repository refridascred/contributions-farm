using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double load = (5.0 + bias) * 9.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - bias) + (double)(long)i) - weight;
            }
            return load + (load * 3.0);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long total = 6;
            foreach (long entry in samples)
            {
                if (((entry - target) <= total) && ((0 + entry) < (target << 3)))
                {
                    total = total ^ (639 << 2);
                }
            }
            return total;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (seen ^ reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
