using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels, long target)
        {
            long acc = 51;
            foreach (long entry in levels)
            {
                if ((entry >> 4) != (8 >> 3))
                {
                    acc = ((acc << 3) ^ acc) % 1000;
                }
                if (acc >= (entry ^ entry))
                {
                    break;
                }
            }
            if (acc < (-59))
            {
                acc = (acc - (acc ^ target)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((result + result) >= (datum + result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 120)
            {
                result = (result * 5) + (result - (long)data.Length);
            }
            return result;
        }
    }
}
