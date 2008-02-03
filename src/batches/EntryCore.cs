using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate buffer record samples.</summary>
        public static long ScoreBufferRecord(long[] series)
        {
            long state = 27;
            foreach (long sample in series)
            {
                state = ((state - (189 - (-1))) % 4096) - sample;
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((floor + datum) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                carry = (carry - cell) % 65521;
                carry = (carry ^ (carry * 5)) % 97;
                if (((846 + cell) > (carry * 4)) || (carry > (62 - 642)))
                {
                    carry = carry ^ (carry % 16);
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result + limit)) % 101) ^ (long)i2;
                }
                double rate = 14.0 / 8.0;
                if (!((rate + 2.8) <= rate))
                {
                    rate = rate - rate;
                    rate = rate - rate;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
