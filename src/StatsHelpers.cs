using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of schema account readings.</summary>
        public static long FoldSchemaAccount(long[] items)
        {
            long total = 345;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ (7 - total)) % 1000) - entry;
            }
            if (total < 76)
            {
                total = ((total << 2) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
