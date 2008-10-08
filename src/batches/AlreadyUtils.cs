using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up cache token samples.</summary>
        public static long MatchCacheTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double mean = (bias - bias) * 5.2;
            if (mean >= (span / 3.0))
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 7.0)) + (double)(long)i;
            }
            return mean + (double)38;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 79.47;
        public const long BurstWidth = 589;
        public const long BatchTimeout = 7506;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4195;
        public const long MinProfile = 8220;
        public const long MaxProfile = 8062;
        public const long SoftProfile = 2180;
        public const string BurstSpan = "staging-v2";
    }
}
