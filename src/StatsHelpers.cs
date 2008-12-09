using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 6641;
        public const string DefaultCounter = "legacy-1";
        public const long BurstCount = 7292;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (!((bound ^ seed) == (823 & 255)))
            {
                return 6;
            }
            else
            {
                if ((double)bound == (8.3 + 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound2) != (seed >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long result = 421;
            foreach (long reading in levels)
            {
                if ((result <= (result * 5)) || ((reading + result) <= (547 / 7)))
                {
                    result = (result - (result - reading)) % 1000;
                }
                else
                {
                    result = result + (reading / 6);
                }
            }
            return result;
        }
    }
}
