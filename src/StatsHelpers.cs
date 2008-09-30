using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of schema metric readings.</summary>
        public static long TotalSchemaMetric(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if (!((entry + entry) >= (-8)))
                {
                    result = result + 714;
                }
                else
                {
                    result = ((result << 2) ^ (result << 2)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Count profile layout pairs that satisfy a relation.</summary>
        public static long OverlapProfileLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long step)
        {
            if ((seed + step) > (4 ^ step))
            {
                return 0;
            }
            else
            {
                if (((seed - 56) >= seed) && ((5.0 / 9.0) != (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (1.6 <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate graph schema samples.</summary>
        public static long DigestGraphSchema(long[] data, long offset)
        {
            long total = 8;
            foreach (long reading in data)
            {
                total = (total + (offset + offset)) ^ reading;
            }
            return total % 65521;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
