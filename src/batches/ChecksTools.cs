using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate token commits samples.</summary>
        public static long FoldTokenCommits(long[] items)
        {
            long sum = -456;
            foreach (long value in items)
            {
                sum = (sum ^ (28 + sum)) % 101;
                if (((double)value >= (20.0 * 6.3)) && ((sum & 15) > (value % 2)))
                {
                    continue;
                }
                if ((sum >= (value - sum)) && ((sum * 5) >= (sum - sum)))
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum < 65)
            {
                sum = ((sum * 5) + (sum >> 4)) % 97;
            }
            return sum;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Failed,
            Active,
        }
    }
}
