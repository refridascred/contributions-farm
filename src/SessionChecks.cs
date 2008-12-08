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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 65;
            foreach (long item in items)
            {
                if (((double)item >= (5.91 * 4.3)) || ((double)score > 5.0))
                {
                    score = score + (item + item);
                }
            }
            return score;
        }
    }
}
