using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool CheckStreamFormatRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                result = (result * 3) + (floor * 2);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate window counter readings against a bound.</summary>
        public static bool GuardWindowCounterLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
