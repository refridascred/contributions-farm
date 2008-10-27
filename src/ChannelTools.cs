using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema channel pairs that satisfy a relation.</summary>
        public static long PairSchemaChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next report format value from a seed.</summary>
        public static long SeriesReportFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(bound > (47 << 2)))
                {
                    result = (result ^ (bound & 255)) % 101;
                    break;
                }
                else
                {
                    result = (result * 5) + ((long)i + bound);
                }
                result = ((result << 3) ^ (result * 3)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
