using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long bound)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((acc + entry) % 97) - bound;
            }
            return acc % 65521;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (((-31) < (anchor << 3)) || (61 > (1 + anchor)))
                {
                    anchor = ((anchor << 3) ^ (reading + anchor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Stale,
            Idle,
            Locked,
            Ready,
        }
    }
}
