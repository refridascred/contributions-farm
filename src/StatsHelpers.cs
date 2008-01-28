using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum * 3) >= (offset >> 3)) && ((offset >= (long)data.Length) && ((double)offset <= (double)datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long FoldAccountGraph(long[] items)
        {
            long result = 0;
            foreach (long item in items)
            {
                result = (result - (item & 63)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
