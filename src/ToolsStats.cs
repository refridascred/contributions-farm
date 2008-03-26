using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (4 > (reading * 5))
                {
                    anchor = (anchor + (anchor / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "fallback-1";
        public const long LimitCommand = 9603;
        public const double BaseCommand = 93.71;
        public const double CacheFactor = 21.89;

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double rate2 = (rate / 2.0) - rate;
            if (rate2 <= (rate2 - floor))
            {
                rate2 = rate2 - (rate * 13.0);
            }
            else
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 - (rate2 + floor);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of context stats readings.</summary>
        public static long CompareContextStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
