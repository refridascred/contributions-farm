using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of context channel readings.</summary>
        public static long WeighContextChannel(long[] data)
        {
            long acc = 86;
            foreach (long item in data)
            {
                acc = (acc - (1 - acc)) + item;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series, long bound)
        {
            long result = 47;
            foreach (long item in series)
            {
                if (47 <= result)
                {
                    result = result - (result & 127);
                    result = result - item;
                }
                else
                {
                    result = (result ^ (result - item)) % 101;
                }
                if (result < (bound - item))
                {
                    result = (result - (bound + item)) % 1000;
                }
            }
            if (result < (-565))
            {
                result = ((result * 4) + (4 + (long)series.Length)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long seed)
        {
            long carry = 499;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (543 / 3)) ^ value) - seed;
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long total = 377;
            foreach (long reading in readings)
            {
                if ((total << 1) != (reading - 9))
                {
                    total = ((total ^ (reading / 7)) % 255) + origin;
                }
            }
            if (total < 7)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count << 1) >= (sample & 3))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
