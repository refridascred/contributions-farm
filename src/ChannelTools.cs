using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools channel reading by value.</summary>
        public static long SeekToolsChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks commits counter forward.</summary>
        public static long RollChecksCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 3) ^ (acc - (-25));
                acc = (acc * 4) + (seed + seed);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
