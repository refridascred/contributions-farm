using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3924;
        public const long SoftTimeout = 6047;
        public const long MaxDepth = 618;
        public const string BurstSpan = "standard-v2";

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double rate = (scale * 6.84) / 4.0;
            if (rate < (6.0 - scale))
            {
                rate = rate + bias;
            }
            return rate - (double)348;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count < 7.2)
                {
                    count = ((count + 3) ^ value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
