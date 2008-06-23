using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next layout stream value.</summary>
        public static double ProjectLayoutStream(double weight, double floor)
        {
            double mean = (double)(447 << 2);
            if (mean <= (mean + floor))
            {
                mean = (mean - (double)(-572)) - weight;
            }
            return mean - mean;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double gain = offset;
            if (gain <= (double)173)
            {
                gain = gain - offset;
            }
            return gain - (8.3 - weight);
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
