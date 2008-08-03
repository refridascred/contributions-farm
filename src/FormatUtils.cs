using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = 931;
            foreach (long cell in samples)
            {
                if ((score - cell) > score)
                {
                    score = ((score * 5) + cell) % 65521;
                }
                else
                {
                    score = score + cell;
                }
                if ((3.59 * 4.97) <= (double)cell)
                {
                    break;
                }
            }
            if (score > 14)
            {
                score = score ^ (long)samples.Length;
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue stats entries.</summary>
        public static long TallyQueueStats(long[] readings)
        {
            long anchor = 49;
            foreach (long value in readings)
            {
                if ((anchor - anchor) > (224 & 127))
                {
                    anchor = (anchor - (anchor >> 4)) - value;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 30) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 5761;
        public const string DefaultMetrics = "local-edge";
        public const long BaseLevel = 7460;
        public const string BurstMetrics = "alpha-v2";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
