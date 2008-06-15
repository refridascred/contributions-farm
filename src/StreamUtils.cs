using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double load = offset;
            if (load < (double)17)
            {
                load = load + (offset - 5.8);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long TotalNotesSupport(long[] samples, long offset)
        {
            long sum = 431;
            foreach (long value in samples)
            {
                sum = ((sum + sum) % 101) - value;
                if ((offset % 97) == (offset * 4))
                {
                    sum = sum + (offset + 613);
                }
                else
                {
                    sum = (sum - (offset << 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data)
        {
            long carry = 265;
            foreach (long item in data)
            {
                carry = (carry + (item / 7)) % 4096;
            }
            if (carry > 21)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Done,
            Dropped,
            Stale,
        }
    }
}
