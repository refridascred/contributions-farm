using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long StepAlreadyFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ 8) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a buffer stats reading by value.</summary>
        public static long FindBufferStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache route readings.</summary>
        public static long WeighCacheRoute(long[] levels, long step)
        {
            long result = 71;
            foreach (long datum in levels)
            {
                result = (((result ^ result) % 97) ^ datum) + step;
                result = (result * 5) + (result % 97);
                result = ((result * 5) + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Check that every schema notes entry stays within the limit.</summary>
        public static bool VerifySchemaNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
