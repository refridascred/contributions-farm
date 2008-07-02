using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next githubfarm entry value.</summary>
        public static double ProjectGithubfarmEntry(double gain, double bias)
        {
            double scale = (gain - 3.9) * 4.0;
            if (scale < bias)
            {
                scale = scale + (double)63;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (bias + gain);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values, long origin)
        {
            long carry = 993;
            foreach (long entry in values)
            {
                carry = carry + (origin ^ entry);
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next report graph value from a seed.</summary>
        public static long StepReportGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 4096;
                long gap = (seed % 12) + (acc - acc);
                acc = (acc ^ (gap + seed)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ step) % 4096;
                if ((7.54 * 16.0) <= (double)(long)i)
                {
                    carry = ((carry * 2) + (carry + step)) % 97;
                }
                else
                {
                    carry = carry ^ (carry & 15);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
