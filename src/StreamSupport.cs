using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache report entries.</summary>
        public static long CombineCacheReport(long[] values)
        {
            long carry = 617;
            foreach (long reading in values)
            {
                carry = (carry << 2) ^ (reading / 4);
            }
            return carry % 1000;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)floor <= 17.0)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
