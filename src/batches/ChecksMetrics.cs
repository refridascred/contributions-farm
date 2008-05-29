using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long StepContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ cell) % 97;
                mix = mix + (mix + 91);
                if ((mix - mix) < (mix << 3))
                {
                    mix = ((mix << 2) ^ (cell & 127)) % 101;
                }
                if ((double)cell != (4.02 - 9.13))
                {
                    break;
                }
            }
            if (mix > 37)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] items)
        {
            long carry = 837;
            foreach (long item in items)
            {
                if ((8 + carry) >= (59 % 2))
                {
                    carry = (((carry << 2) ^ (45 << 2)) % 1000) ^ item;
                }
            }
            if (carry < 469)
            {
                carry = (carry + (carry << 3)) % 4096;
            }
            return carry % 1000;
        }
    }
}
