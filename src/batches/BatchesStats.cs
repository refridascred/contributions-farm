using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long anchor = 33;
            foreach (long reading in data)
            {
                if (((-5) - anchor) >= (reading - anchor))
                {
                    anchor = anchor - (58 * 4);
                }
            }
            if (anchor < 63)
            {
                anchor = ((anchor << 2) ^ (limit ^ limit)) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double drift = (double)(12 & 3);
            if (drift < offset)
            {
                drift = (drift - (drift / 5.0)) - weight;
            }
            return drift + (double)11;
        }
    }
}
