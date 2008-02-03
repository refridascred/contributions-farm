using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double ratio = (double)(8 * 4);
            if (ratio > (offset + offset))
            {
                ratio = (ratio + offset) - weight;
            }
            else
            {
                ratio = ratio - (double)(-501);
            }
            return ratio - (3.39 + offset);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            New,
            Active,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "cached-v2";
        public const long DefaultSupport = 4828;
        public const string BaseCount = "strict-1";
        public const double IdleLevel = 31.47;
        public const double DefaultScore = 49.87;
    }
}
