using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - origin) > matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                if (value > result)
                {
                    result = ((result << 3) ^ result) % 255;
                }
                else
                {
                    result = (result * 3) + value;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowCount = "cached-edge";
        public const double DefaultInterval = 52.69;
        public const long HardBudget = 3950;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double drift = 9.1 - floor;
            if (drift < (double)67)
            {
                drift = (drift - (double)37) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor / 8.0)) - (double)(long)i;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3920;
        public const long WindowQueue = 814;
        public const long MaxQueue = 7075;
    }
}
