using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            Active,
            Done,
            Pending,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long FindContributiGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long DeriveLayoutOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                long matches = (limit ^ result) << 2;
                matches = ((matches * 4) + (matches ^ result)) % 101;
                if ((double)limit < 6.8)
                {
                    result = (result ^ matches) % 255;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry & 7) == (entry * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
