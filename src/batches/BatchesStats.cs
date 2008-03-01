using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long MeasureContributiLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (72 + 8))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count notes queue pairs that satisfy a relation.</summary>
        public static long CompareNotesQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
