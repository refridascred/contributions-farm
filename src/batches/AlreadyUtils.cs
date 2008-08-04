using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long DigestEntryGithubfarm(long[] samples, long bound)
        {
            long sum = 31;
            foreach (long value in samples)
            {
                if ((long)samples.Length <= (value / 5))
                {
                    sum = (sum << 3) ^ (sum >> 5);
                }
                if ((sum ^ 2) == (bound + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double bias2 = span - (double)(-52);
            if (bias2 > bias)
            {
                bias2 = bias2 - span;
            }
            else
            {
                bias2 = bias2 + 8.0;
            }
            return bias2 + (span * 8.72);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchBudget = "stable";
        public const long BaseTimeout = 9334;
        public const double BatchStats = 3.4;

        /// <summary>Digest a series of counter command entries.</summary>
        public static long CombineCounterCommand(long[] series, long offset)
        {
            long acc = 127;
            foreach (long value in series)
            {
                if (!((offset - value) < 4))
                {
                    acc = (acc ^ 3) % 65521;
                }
                else
                {
                    acc = (acc ^ ((long)series.Length + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Iterate the format support series from a seed.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
