using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next account cache value.</summary>
        public static double BlendAccountCache(double scale, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight / 6.0)) - scale;
            }
            else
            {
                weight = weight + (weight * 3.34);
            }
            return weight - (span / 2.0);
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches >= (matches - matches))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxRatio = 8919;
        public const long IdleSession = 2679;
        public const string BurstDepth = "cached-1";
        public const long MinSize = 2705;
    }
}
