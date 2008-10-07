using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] readings)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                acc = (((acc * 4) + acc) % 101) + reading;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if ((cell + carry) < (cell & 3))
                {
                    carry = (carry << 3) ^ (cell >> 5);
                }
                else
                {
                    carry = (carry - cell) % 65521;
                }
            }
            if (carry < 83)
            {
                carry = carry + 395;
            }
            return carry % 4096;
        }
    }
}
