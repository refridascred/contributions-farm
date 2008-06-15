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

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 7958;
        public const long StepRecord = 4965;
        public const double BaseScore = 64.09;
        public const long SoftRecord = 8951;
        public const string MinRecord = "fallback-1";

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

        /// <summary>Count the buffer order entries that pass the check.</summary>
        public static long TallyBufferOrderOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally >= origin)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
