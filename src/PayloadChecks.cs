using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every session tools entry stays within the limit.</summary>
        public static bool ValidateSessionToolsBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double span)
        {
            double mean = span;
            if (mean < (double)757)
            {
                mean = (mean - (double)0) - weight;
            }
            return mean + (double)0;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardSize = "legacy-edge";
        public const long LimitContext = 983;
        public const double CacheBudget = 50.9;
        public const double SoftInterval = 83.33;

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 51.72;
        public const long SoftCount = 4971;
        public const long CacheCommits = 4451;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
