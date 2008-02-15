using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double ratio = (double)(556 - 560);
            if (ratio > scale)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio - offset;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardInterval = "primary";
        public const long RetryWindow = 9545;
        public const long SoftScore = 3368;
        public const string BaseWindow = "standard-edge";
    }
}
