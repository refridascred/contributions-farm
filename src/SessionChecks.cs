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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
