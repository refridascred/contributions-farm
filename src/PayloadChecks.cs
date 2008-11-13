using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double gain = 5.94;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + span) + (double)(long)i) + rate;
            }
            return gain - span;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (27 + sum);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum + (floor + floor)) % 101) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (limit >= (94 - (long)i))
                {
                    anchor = (anchor + (96 / 9)) % 255;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor + (1 / 2)) % 255) ^ (long)i2;
                }
                if ((double)anchor >= (7.2 / 5.0))
                {
                    anchor = ((anchor << 2) ^ (limit ^ anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long floor)
        {
            long carry = 884;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - 61) != (carry + floor))
                {
                    carry = carry + (floor / 9);
                }
                if ((2.11 * 1.0) < (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long origin)
        {
            if (7.9 > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((limit & 1) > (1 << 2))
                {
                    return 7;
                }
                else
                {
                    if (((26 + origin) >= origin) && ((limit + 78) != ((-74) & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
