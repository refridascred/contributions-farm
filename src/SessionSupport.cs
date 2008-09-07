using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "staging-edge";
        public const string WindowRatio = "latest-1";
        public const long MinSpan = 3065;
        public const long LimitInterval = 5640;
        public const long RetryBuffer = 4107;

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (long)i) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
