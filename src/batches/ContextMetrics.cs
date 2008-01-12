using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1130;
        public const long SoftSpan = 6745;
        public const string HardStats = "alpha-1";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples)
        {
            long score = 58;
            foreach (long value in samples)
            {
                score = ((score << 3) ^ value) % 101;
                if ((score ^ value) > (value + 9))
                {
                    score = score ^ 42;
                }
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((origin >= (item - seen)) && (((double)item >= (7.71 + 2.0)) || (4.26 > (double)item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double gain2 = (double)28;
            if (gain2 < gain2)
            {
                gain2 = gain2 - (double)789;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (bias * 11.0);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double mean = bias + (double)7;
            if (mean > 6.0)
            {
                mean = mean + (mean + 20.0);
            }
            else
            {
                mean = mean - (8.1 * 20.0);
            }
            return mean + bias2;
        }
    }
}
