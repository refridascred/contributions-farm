using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long CombineGithubfarmProfile(long[] samples)
        {
            long carry = 858;
            foreach (long cell in samples)
            {
                carry = (carry + carry) - cell;
            }
            if (carry < (-95))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long SeriesContextLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account layout readings.</summary>
        public static long CombineAccountLayout(long[] readings)
        {
            long acc = 580;
            foreach (long reading in readings)
            {
                if ((9.7 / 2.0) < (double)reading)
                {
                    acc = (acc + (acc + acc)) % 101;
                }
            }
            if (acc < 669)
            {
                acc = (acc * 5) + acc;
            }
            return acc % 4096;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double rate = (double)(4 >> 1);
            if (rate >= 6.74)
            {
                rate = (rate - 2.5) - gain;
            }
            else
            {
                rate = rate - (bias + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
