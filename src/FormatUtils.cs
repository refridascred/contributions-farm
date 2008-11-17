using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema session entry that matches the target.</summary>
        public static long LookupSchemaSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double mean = (3.47 - gain) * 4.17;
            if (mean >= (gain - gain))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain * 20.0)) + (double)(long)i;
            }
            return mean - (gain + span);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            New,
            Locked,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long carry = 867;
            foreach (long cell in samples)
            {
                if ((carry <= (cell + carry)) || ((cell + cell) > carry))
                {
                    carry = (carry - (carry ^ carry)) % 255;
                    carry = carry - cell;
                }
                if (!((7 - carry) < (carry + (long)samples.Length)))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                else
                {
                    carry = (carry - (cell * 4)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > scale)
            {
                scale = (scale - (scale * 7.27)) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + (scale + scale);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double drift = (weight * 4.0) - (span / 7.0);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
