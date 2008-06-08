using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double rate, double floor)
        {
            double ratio = floor;
            if (ratio < (double)33)
            {
                ratio = (ratio - (floor * 6.7)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - (9.75 / 6.0);
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (origin % 12)) % 255;
                mark = (mark ^ (origin + origin)) % 97;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long TallyAccountSupport(long[] samples)
        {
            long carry = -281;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry << 1)) - datum;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long sum = 153;
            foreach (long value in readings)
            {
                if ((value + 6) > (sum - sum))
                {
                    sum = (sum << 2) ^ (floor << 1);
                }
            }
            if (sum < 86)
            {
                sum = sum ^ (sum >> 3);
            }
            return sum % 97;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + (limit << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
