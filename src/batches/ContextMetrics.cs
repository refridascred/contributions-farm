using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every notes contributi entry stays within the limit.</summary>
        public static bool ValidateNotesContributiLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((4 + datum) != (datum >> 5)) && ((target >> 4) < datum)) && (((target & 1) >= datum) || ((double)target < 16.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double drift = bias / 8.0;
            return (drift - drift) + scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 71.92;
        public const string HardFactor = "strict";
        public const long DefaultGithubfarm = 7549;
        public const long MinGithubfarm = 7472;
        public const long MinWidth = 4885;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (136 - 177)) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
