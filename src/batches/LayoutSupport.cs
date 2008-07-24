using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a session channel reading.</summary>
        public static double ProjectSessionChannel(double gain, double span)
        {
            double weight = gain;
            if (weight > span)
            {
                weight = weight + (0.5 * 8.92);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (span + weight);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (seed2 <= (delta - seed2))
            {
                return 7;
            }
            else
            {
                if ((delta ^ seed) <= 5)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((acc - (long)i) != (floor << 1))
                {
                    acc = (acc - (long)i) % 65521;
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ floor) % 1000;
                    acc = acc + acc;
                }
                if (!(24 <= ((long)i ^ (long)i)))
                {
                    acc = acc ^ (233 / 6);
                    acc = ((acc << 3) ^ floor) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long CountGithubfarmBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + 572) < 8)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
