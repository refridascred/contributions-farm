using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long FindRouteClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of metric order entries.</summary>
        public static long WeighMetricOrder(long[] samples)
        {
            long state = 76;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    long delta = (cell * 5) + ((long)i << 1);
                    state = ((state << 2) ^ (state + delta)) % 97;
                }
                if (((state ^ state) <= (cell / 3)) || ((cell * 4) == (state & 15)))
                {
                    state = ((state << 3) ^ (state - cell)) % 65521;
                }
            }
            if (state > 126)
            {
                state = ((state << 2) ^ (5 / 8)) % 97;
            }
            return state;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (16.0 - 4.52))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
