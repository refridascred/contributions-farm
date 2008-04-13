using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long acc = 14;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    acc = (acc - (limit / 3)) % 4096;
                }
            }
            if (acc > 38)
            {
                acc = (acc * 3) + limit;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long total = 65;
            foreach (long item in readings)
            {
                total = (((total + 594) % 101) + item) + step;
            }
            return total;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long PairLayoutAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
