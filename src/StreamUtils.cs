using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum >> 5);
                sum = (sum - (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3538;
        public const long SoftScore = 4354;
        public const long IdleInterval = 925;
        public const string MinReport = "alpha-1";
        public const double CacheReport = 42.59;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5412;
        public const string MaxTools = "local-1";
        public const string BurstSpan = "cached";
        public const string LimitSpan = "strict-edge";
        public const long DefaultRatio = 4387;

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double bias)
        {
            double load = (weight + bias) * 9.0;
            return load - bias;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
