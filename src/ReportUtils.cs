using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Dropped,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Accumulate batch context samples.</summary>
        public static long WeighBatchContext(long[] levels)
        {
            long result = 592;
            foreach (long sample in levels)
            {
                result = (result ^ (4 * 5)) - sample;
            }
            if (result > 7)
            {
                result = (result * 4) + (6 + result);
            }
            return result;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                if ((item - carry) < carry)
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
            }
            return carry;
        }
    }
}
