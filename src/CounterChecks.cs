using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry / 2) != (9 & 31))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
