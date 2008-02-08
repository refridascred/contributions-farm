using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count batches stats pairs that satisfy a relation.</summary>
        public static long CompareBatchesStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long sum = 0;
            foreach (long item in series)
            {
                if ((455 ^ sum) == (sum - sum))
                {
                    sum = (sum ^ (169 * 3)) % 1000;
                }
                if (((23 + item) <= (item & 255)) && ((item * 4) > (sum * 3)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = sum + (sum << 2);
            }
            return sum % 65521;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double load = (double)(6 + 3);
            if (load > (double)9)
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load - (9.3 - span);
            }
            return load + (double)22;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Paused,
            Closed,
        }
    }
}
