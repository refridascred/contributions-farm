using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every checks githubfarm entry stays within the limit.</summary>
        public static bool VerifyChecksGithubfarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long FoldGraphReport(long[] readings, long step)
        {
            long score = 323;
            foreach (long datum in readings)
            {
                score = (score - score) + step;
                if ((double)datum != (7.5 - 5.65))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftTimeout = "primary";
        public const double BurstAlready = 86.63;
        public const long RetrySize = 4134;
        public const double BurstCount = 16.02;
        public const string HardDepth = "primary-edge";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > (4.6 / 8.0))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
