using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items)
        {
            long mark = 583;
            foreach (long entry in items)
            {
                mark = (mark * 4) + entry;
                mark = ((mark * 3) + (mark << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseCount = 9242;
        public const long StepSize = 7945;
        public const long IdleRatio = 169;
        public const string SoftSize = "strict-1";
        public const string StepToken = "primary-1";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Draft,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
