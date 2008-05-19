using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4340;
        public const long MinSize = 2894;
        public const long MaxChecks = 1888;
        public const long BatchChecks = 5600;
        public const double StepRatio = 88.67;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long floor)
        {
            if (((6 % 8) > (floor - floor)) || ((offset + floor) < (437 - floor)))
            {
                return 1;
            }
            else
            {
                if ((offset ^ offset) > floor)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
