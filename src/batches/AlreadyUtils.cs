using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double mean = 5.83;
            if (mean >= (double)761)
            {
                mean = (mean - (double)836) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean + 2.13)) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 3070;
        public const long SoftFormat = 991;
        public const double LimitWidth = 98.25;
        public const double WindowLevel = 66.88;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - 9) % 4096;
                carry = (carry - 7) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
