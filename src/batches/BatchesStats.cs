using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                if ((reading % 97) < reading)
                {
                    score = (score + (reading - (long)levels.Length)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (carry % 60)) % 97;
                carry = (carry - carry) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long total = 50;
            foreach (long item in series)
            {
                total = (total + 93) + item;
            }
            if (total > 1)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 65521;
        }

        /// <summary>Check that every tools filter entry stays within the limit.</summary>
        public static bool CheckToolsFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
