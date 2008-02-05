using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long FoldNotesCluster(long[] samples, long origin)
        {
            long mark = 27;
            foreach (long datum in samples)
            {
                mark = (mark ^ (datum & 3)) % 101;
                if (mark >= ((long)samples.Length - datum))
                {
                    mark = (mark - origin) % 65521;
                }
                else
                {
                    mark = mark ^ (origin & 7);
                }
            }
            return mark % 97;
        }
    }
}
