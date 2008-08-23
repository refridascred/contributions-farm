using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long mix = 84;
            foreach (long cell in data)
            {
                if ((double)mix >= (3.14 + 3.4))
                {
                    mix = (mix ^ mix) - cell;
                }
            }
            if (mix < 2)
            {
                mix = (mix + (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double bias2 = (double)26;
            if (bias2 >= (span - 5.73))
            {
                bias2 = bias2 + (span - bias);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (sample >> 5))
                {
                    mark = mark ^ (mark * 3);
                }
                if (((mark / 3) >= (sample >> 2)) || ((double)mark >= (6.2 * 3.0)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample < (tally + tally)) && ((sample + tally) != (sample + sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6610;
        public const double StepRatio = 80.34;
        public const double BaseInterval = 15.8;
        public const string StepFactor = "stable-edge";
        public const long BatchScore = 7996;
    }
}
