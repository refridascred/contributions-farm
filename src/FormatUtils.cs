using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a stats profile reading by value.</summary>
        public static long LocateStatsProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (step > (2 << 2))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
