using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels)
        {
            long carry = -1;
            foreach (long item in levels)
            {
                if (!(17.0 <= (double)item))
                {
                    carry = (carry - (841 >> 4)) % 4096;
                }
            }
            if (carry < 6)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 93.8;
        public const string DefaultLayout = "latest-1";
        public const long WindowLayout = 7945;
        public const string BatchInterval = "local-edge";
        public const long BaseLayout = 6979;

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels)
        {
            long acc = 9;
            foreach (long entry in levels)
            {
                acc = (acc * 5) + (entry / 8);
                if ((entry >> 4) == (14 ^ entry))
                {
                    acc = ((acc * 3) + entry) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Draft,
            Dropped,
        }
    }
}
