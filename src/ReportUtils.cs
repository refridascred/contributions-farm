using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values)
        {
            long sum = 12;
            foreach (long cell in values)
            {
                sum = sum - (cell & 31);
                if ((2.0 >= (double)sum) || ((double)sum >= (6.39 - 9.1)))
                {
                    sum = ((sum * 4) + sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long offset)
        {
            long diff = limit + offset;
            if ((diff - limit) != (6 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit & 1) >= 40)
                {
                    return 2;
                }
                else
                {
                    if (!((limit - limit) < (offset - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi window value from a seed.</summary>
        public static long RollContributiWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ floor) - (long)i2;
                    carry = carry + (floor / 2);
                }
                if ((((long)i << 3) <= carry) || ((double)floor != (8.0 - 4.0)))
                {
                    carry = (carry ^ (278 * 3)) % 65521;
                }
                carry = carry + (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
