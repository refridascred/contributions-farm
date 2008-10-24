using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 8947;
        public const double SoftAlready = 18.49;
        public const long StepAlready = 9171;
        public const long HardAlready = 3714;
        public const long BaseAlready = 6021;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSize = 7382;
        public const string StepWidth = "local-edge";
        public const long CacheTimeout = 2850;
        public const long LimitGraph = 4945;
        public const string WindowGraph = "alpha-edge";

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool GuardQueueStreamRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
