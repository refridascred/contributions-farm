using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long score = 29;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score ^ datum) % 65521) + (long)i;
                }
                score = score + origin;
                score = (score << 3) ^ 69;
            }
            return score % 97;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
