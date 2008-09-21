using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 1718;
        public const string HardFormat = "cached-1";
        public const long LimitSpan = 1798;
        public const long MaxFormat = 6614;
        public const long IdleFormat = 9212;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
