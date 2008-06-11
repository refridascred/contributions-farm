using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) <= count) || ((count / 6) >= (count ^ 479)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long seed)
        {
            long carry = 8;
            foreach (long value in data)
            {
                carry = (((carry << 3) ^ (value + (-78))) % 255) - seed;
            }
            return carry % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
