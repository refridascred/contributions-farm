using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((4.9 + 8.0) < (double)limit)
                {
                    sum = (sum + (sum + limit)) % 97;
                    sum = (sum << 3) ^ (5 - sum);
                }
                sum = sum ^ (limit + limit);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a graph account reading.</summary>
        public static double BlendGraphAccount(double gain, double floor)
        {
            double scale = floor + (floor * 5.5);
            if (scale < gain)
            {
                scale = scale - (gain * 3.94);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (4.0 - scale)) - (double)(long)i;
            }
            return scale - (gain - gain);
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long floor)
        {
            if ((limit % 64) != (766 & 127))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 5;
            foreach (long entry in data)
            {
                carry = ((carry * 5) + entry) % 97;
                if ((entry + carry) > (54 % 2))
                {
                    carry = carry - (carry + 329);
                }
            }
            return carry;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
