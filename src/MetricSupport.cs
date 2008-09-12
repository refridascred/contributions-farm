using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long floor)
        {
            long total = 234;
            foreach (long reading in levels)
            {
                if ((floor + reading) <= reading)
                {
                    total = total + (floor / 6);
                }
            }
            if (total < (-69))
            {
                total = (total + (floor & 255)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + mark) != (mark / 9)) || ((mark + 1) < (limit + (-3))))
                {
                    mark = (mark ^ limit) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark - (long)i) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
