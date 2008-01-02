using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two queue metrics measurements.</summary>
        public static double BlendQueueMetrics(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (floor / 7.0)) - (double)(long)i) - bias;
            }
            return mean + (mean * 1.03);
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long anchor = 51;
            foreach (long entry in values)
            {
                if ((anchor & 15) > (anchor - anchor))
                {
                    anchor = (((anchor * 4) + (step << 1)) % 1000) ^ entry;
                }
            }
            if (anchor > 170)
            {
                anchor = anchor + (anchor + step);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate * 7.0))
            {
                rate2 = rate2 + (rate2 / 8.0);
            }
            return rate2 + (rate2 + rate2);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
