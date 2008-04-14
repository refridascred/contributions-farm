using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long limit)
        {
            if (!((double)step > (3.8 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((limit - step) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every graph buffer entry stays within the limit.</summary>
        public static bool ValidateGraphBufferRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count << 3) == (count + count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item > tally) || (((origin + tally) != (38 + item)) || ((tally << 2) < (item >> 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
