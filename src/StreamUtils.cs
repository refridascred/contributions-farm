using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double offset)
        {
            double load = (ratio * 16.0) / 4.0;
            if (load <= (ratio * 4.22))
            {
                load = load - (offset - 5.28);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (offset - ratio)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            New,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((seed - seed) > (carry & 255)) || ((double)24 != (double)carry))
                {
                    carry = (carry + seed) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 5094;
        public const long MaxStream = 821;
        public const double IdleDepth = 63.13;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                if ((94 + target) <= (result - result))
                {
                    result = ((result << 2) ^ 510) % 101;
                }
                else
                {
                    result = result ^ target;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Queued,
            Idle,
            Ready,
            New,
        }
    }
}
