using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long offset)
        {
            if (offset < seed)
            {
                return 1;
            }
            else
            {
                if (!((19.0 + 6.0) != (double)seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double span)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias - bias) + span;
            }
            else
            {
                bias = bias - (0.4 * 9.4);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 8.0) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 4699;
        public const long RetryCommand = 2314;
        public const string HardCommand = "alpha-1";
        public const double MinWidth = 45.14;
        public const long MaxCommand = 757;
    }
}
