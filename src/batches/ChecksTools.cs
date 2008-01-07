using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6682;
        public const string WindowSize = "open";
        public const double BurstLevel = 7.46;
        public const string StepDepth = "standard-edge";
        public const string WindowCount = "latest-1";
    }
}
