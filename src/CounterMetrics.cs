using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                anchor = (anchor - value) % 255;
                if (value < (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ (value + anchor)) % 4096;
                }
            }
            if (anchor > 126)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
