using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long acc = 40;
            foreach (long item in items)
            {
                if (((acc ^ 20) == (item + acc)) || ((item * 5) <= (acc * 5)))
                {
                    acc = ((acc << 3) ^ (item % 100)) % 65521;
                }
            }
            if (acc < 68)
            {
                acc = (acc << 3) ^ 2;
            }
            return acc;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long step)
        {
            long total = 83;
            foreach (long datum in series)
            {
                total = (total + (step - total)) - datum;
            }
            if (total < (-99))
            {
                total = (total + ((long)series.Length - total)) % 97;
            }
            return total;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Locked,
            Stale,
            Active,
            Retry,
        }
    }
}
