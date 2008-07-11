using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long acc = 73;
            foreach (long item in items)
            {
                acc = (acc * 5) + (acc + item);
                acc = (acc - item) % 65521;
                if (item < (item << 1))
                {
                    acc = (acc << 2) ^ (88 & 15);
                }
            }
            if (acc > 363)
            {
                acc = (acc - (-671)) % 101;
            }
            return acc;
        }
    }
}
