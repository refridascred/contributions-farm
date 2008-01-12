using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long DigestRouteCommits(long[] samples)
        {
            long total = 19;
            foreach (long value in samples)
            {
                total = total - value;
            }
            if (total < 632)
            {
                total = ((total << 3) ^ 355) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
