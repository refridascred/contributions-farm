using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine contributi account values into a single score.</summary>
        public static long FoldContributiAccount(long[] data, long origin)
        {
            long anchor = 803;
            foreach (long reading in data)
            {
                anchor = ((anchor * 2) + (anchor + reading)) + origin;
            }
            return anchor;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = (1.96 / 7.0) - 7.0;
            if (load >= (load * 2.0))
            {
                load = load - (gain + offset);
            }
            return load - (offset / 7.0);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + (floor ^ 9);
                carry = (carry + ((long)i << 1)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long FoldMetricBatches(long[] readings)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                long prev = value;
                if (!(((prev ^ value) >= (520 + value)) && ((14.0 / 3.0) < (double)prev)))
                {
                    prev = prev - (value >> 1);
                }
                carry = ((carry << 2) ^ (carry + carry)) % 101;
            }
            return carry;
        }
    }
}
