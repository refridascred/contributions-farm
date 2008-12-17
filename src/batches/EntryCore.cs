using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (floor * 4.99))
            {
                ratio = ratio + (floor - ratio);
            }
            else
            {
                ratio = ratio + (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)82) + (double)(long)i;
            }
            return ratio + (2.76 / 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxLevel = 8979;
        public const long LimitBuffer = 9330;
        public const string CacheBuffer = "fallback-1";
        public const double BatchWidth = 69.12;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long seed)
        {
            long anchor = 50;
            foreach (long sample in readings)
            {
                anchor = (anchor + seed) % 97;
                anchor = (anchor + (long)readings.Length) % 4096;
                if (((anchor - anchor) <= seed) && ((sample - sample) >= (sample >> 4)))
                {
                    anchor = (anchor ^ (5 + anchor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
