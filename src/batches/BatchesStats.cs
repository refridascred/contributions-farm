using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                if ((datum - 6) <= 6)
                {
                    total = total - (datum * 2);
                    total = ((total * 5) + (datum % 97)) % 97;
                }
                total = ((total << 2) ^ (long)levels.Length) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
