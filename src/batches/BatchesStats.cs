using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            New,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data, long limit)
        {
            long mix = 936;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix + (limit >> 3)) % 101) ^ (long)i) ^ value;
                }
                mix = mix - (mix - 226);
            }
            return mix;
        }
    }
}
