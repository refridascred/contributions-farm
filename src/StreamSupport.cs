using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate report contributi samples.</summary>
        public static long FoldReportContributi(long[] values)
        {
            long score = -65;
            foreach (long sample in values)
            {
                if ((sample + score) == (score + sample))
                {
                    score = ((score * 4) + (sample ^ sample)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
