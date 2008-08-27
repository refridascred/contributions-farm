using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "stable";
        public const string DefaultFactor = "open-1";
        public const long StepRatio = 254;

        /// <summary>Count the githubfarm token entries that pass the check.</summary>
        public static long MeasureGithubfarmTokenGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((7.43 - 8.1) != (double)seed)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((target << 1) > count) && (((161 - (-62)) != (73 - datum)) && ((target / 4) <= target)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
