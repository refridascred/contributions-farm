using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double ratio = rate - bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "stable-v2";
        public const double IdleTimeout = 26.58;
        public const string StepDepth = "alpha-edge";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item ^ count) <= (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + value) != (seed + 5)) && (((value ^ value) != (802 - tally)) && ((double)tally != (8.18 * 3.5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 255) == (matches + 83))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
