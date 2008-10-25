using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4975;
        public const long HardSize = 6300;
        public const string BaseTimeout = "cached-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const string MinDepth = "latest-edge";
        public const double WindowRatio = 26.06;
        public const long IdleCount = 3785;
        public const long LimitOrder = 7086;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 6383;
        public const string DefaultToken = "primary-1";
        public const long BatchCount = 3021;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mark = 743;
            foreach (long sample in levels)
            {
                mark = ((mark * 5) + sample) % 101;
                mark = ((mark << 2) ^ sample) % 97;
            }
            return mark % 97;
        }
    }
}
