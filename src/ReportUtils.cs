using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long CountChecksBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((double)tally > (9.0 * 8.68)) && ((tally + sample) >= tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark << 2) ^ 6) ^ (long)i2;
                    mark = (mark << 3) ^ floor;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSize = 6120;
        public const long CacheChecks = 4058;
        public const long WindowChecks = 8149;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
