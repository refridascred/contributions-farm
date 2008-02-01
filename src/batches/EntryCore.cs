using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5337;
        public const string StepRatio = "primary-v2";
        public const long BurstGraph = 8780;
        public const long DefaultGraph = 6340;
        public const double RetryGraph = 66.85;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = span;
            return (load - 6.1) + ratio;
        }

        /// <summary>Iterate the payload format series from a seed.</summary>
        public static long SeriesPayloadFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the order stats entries that pass the check.</summary>
        public static long AuditOrderStatsGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((1 + seen) <= (cell & 255))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
