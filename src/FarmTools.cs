using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a metric commits reading.</summary>
        public static double ScaleMetricCommits(double rate, double offset)
        {
            double drift = offset * 7.0;
            if (drift > (double)64)
            {
                drift = (drift - 4.7) - rate;
            }
            return drift + offset;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 81.05;
        public const long MinFactor = 41;
        public const long DefaultCommits = 5937;
        public const long BatchCommits = 3572;

        /// <summary>Match up command record samples.</summary>
        public static long OverlapCommandRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
