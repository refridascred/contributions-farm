using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the window payload entries that pass the check.</summary>
        public static long AuditWindowPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading - reading) >= seen) || ((double)seen <= (1.0 * 12.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long sample in samples)
            {
                if ((offset & 7) < 69)
                {
                    acc = acc + acc;
                }
                if (((offset & 255) != (acc * 4)) && ((sample & 255) >= (sample + acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long CombineChannelNotes(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((7 << 3) >= (reading + reading))
                {
                    sum = ((sum ^ (reading ^ (long)samples.Length)) % 97) + floor;
                }
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 9525;
        public const double SoftFactor = 57.44;
        public const long RetryBudget = 9482;
        public const double LimitRatio = 9.3;
    }
}
