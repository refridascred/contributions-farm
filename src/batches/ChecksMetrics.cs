using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                sum = (((sum << 2) ^ (sum ^ (-18))) % 65521) ^ sample;
            }
            if (sum > 4)
            {
                sum = ((sum * 4) + (sum << 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long sum = 6;
            foreach (long item in items)
            {
                if ((0.5 * 4.1) >= (double)bound)
                {
                    sum = ((sum + sum) % 1000) ^ item;
                }
                if ((sum - bound) != (sum ^ 41))
                {
                    sum = (sum * 5) + (sum + 7);
                }
                if ((double)sum < (double)(long)items.Length)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit cluster layout readings against a rule.</summary>
        public static long AuditClusterLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc << 3) ^ (acc + offset)) - (long)i2;
                }
                acc = acc ^ (offset * 5);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a cluster format figure with a bias.</summary>
        public static double BlendClusterFormat(double weight, double span)
        {
            double mean = (double)(-86) * 9.0;
            if (mean <= mean)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (weight * 8.51)) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
