using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheDepth = 898;
        public const double IdleSession = 37.73;
        public const double MinLevel = 47.98;

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepSize = 6561;
        public const string StepLevel = "latest";
        public const double DefaultEntry = 38.14;
        public const long LimitEntry = 2449;
        public const long CacheTimeout = 9787;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                acc = acc + ((long)series.Length & 31);
                acc = (acc + ((long)series.Length >> 5)) % 255;
                if (((acc + (-1)) >= (991 & 255)) && ((acc - datum) >= (acc & 255)))
                {
                    acc = (acc ^ (datum << 2)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + datum) % 65521;
                }
            }
            return acc;
        }
    }
}
