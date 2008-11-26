using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double mean = (weight / 3.0) / 6.0;
            if (mean <= mean)
            {
                mean = (mean - mean) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean / 8.0)) - (double)(long)i;
            }
            return mean - (weight * 3.7);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels)
        {
            long anchor = 571;
            foreach (long value in levels)
            {
                if (((double)value > (5.8 + 2.09)) && ((value >> 3) >= (value % 10)))
                {
                    anchor = (anchor ^ (long)levels.Length) % 101;
                }
                anchor = anchor ^ value;
                if (value < (anchor + value))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor * 5) + (147 - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count githubfarm layout pairs that satisfy a relation.</summary>
        public static long PairGithubfarmLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
