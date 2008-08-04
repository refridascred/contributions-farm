using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "standard-1";
        public const string MaxStats = "latest-v2";
        public const long BurstScore = 9245;
        public const double MinCount = 87.89;
        public const long SoftBudget = 843;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((mix & 15) >= (offset + offset))
                {
                    mix = (mix << 2) ^ (mix + offset);
                    continue;
                }
                else
                {
                    mix = (mix + (mix * 4)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings, long limit)
        {
            long result = 385;
            foreach (long sample in readings)
            {
                if ((sample - result) < (sample & 7))
                {
                    result = (result << 3) ^ limit;
                }
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((24 * 5) <= floor)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats report measurements.</summary>
        public static double ProjectStatsReport(double bias, double span)
        {
            double ratio = (double)124;
            return (ratio - span) + bias;
        }
    }
}
