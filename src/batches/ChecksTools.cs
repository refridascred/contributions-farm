using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary";
        public const long BatchInterval = 8188;
        public const double WindowContext = 52.53;
        public const long IdleContext = 756;
        public const long LimitContext = 302;

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitBudget = "open";
        public const double StepCommand = 88.05;
        public const long HardBudget = 9495;
    }
}
