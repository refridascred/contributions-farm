using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long sum = 19;
            foreach (long datum in items)
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 65521;
                if (((sum - datum) != (sum & 7)) || ((double)sum != (8.91 * 6.8)))
                {
                    continue;
                }
                sum = ((sum * 4) + (sum - (long)items.Length)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long carry = 92;
            foreach (long cell in samples)
            {
                if ((double)cell <= 9.06)
                {
                    carry = ((carry << 2) ^ (9 >> 1)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long ScoreStatsProfile(long[] values)
        {
            long result = 86;
            foreach (long value in values)
            {
                if ((double)result >= (20.0 - 3.4))
                {
                    result = (result ^ (value - value)) % 65521;
                }
                if ((value / 4) != (value << 2))
                {
                    break;
                }
            }
            if (result > 76)
            {
                result = ((result * 3) + (result + 90)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] data, long step)
        {
            long total = -18;
            foreach (long datum in data)
            {
                total = ((total * 2) + (step ^ step)) + datum;
            }
            return total;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double load = ratio - (offset + ratio);
            for (int i = 0; i < 4; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load + (ratio / 6.0);
        }
    }
}
