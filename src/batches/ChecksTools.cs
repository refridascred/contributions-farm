using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels, long offset)
        {
            long result = 863;
            foreach (long reading in levels)
            {
                if ((offset >> 3) != (30 - reading))
                {
                    result = result + reading;
                }
            }
            if (result < 3)
            {
                result = (result * 2) + (offset / 3);
            }
            return result % 65521;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Pending,
            Idle,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
