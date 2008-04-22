using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a contributi checks reading by value.</summary>
        public static long SeekContributiChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi stream reading.</summary>
        public static double ScaleContributiStream(double scale, double floor)
        {
            double mean = (double)(607 * 5);
            if (mean <= (scale / 3.0))
            {
                mean = mean - (8.2 + scale);
            }
            return mean - (mean + floor);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 2015;
        public const long RetryLevel = 8551;
        public const string MaxBudget = "primary";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Ready,
            Draft,
        }
    }
}
