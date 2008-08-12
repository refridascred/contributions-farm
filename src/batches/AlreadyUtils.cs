using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of entry metric readings.</summary>
        public static long PairEntryMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinTimeout = 202;
        public const long LimitBudget = 4241;
        public const double SoftSession = 97.19;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
