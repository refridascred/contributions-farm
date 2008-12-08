using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long anchor = 243;
            foreach (long sample in data)
            {
                anchor = ((anchor + (anchor << 3)) % 255) ^ sample;
            }
            return anchor;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next commits already value from a seed.</summary>
        public static long DeriveCommitsAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum ^ (73 * 3)) % 65521;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
