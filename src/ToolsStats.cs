using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of context route readings.</summary>
        public static long PairContextRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long RankCacheFilter(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((next ^ 833) < (8 % 97))
            {
                return 5;
            }
            else
            {
                if (!((73 << 3) == (31 + origin)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long offset)
        {
            long mix = -7;
            foreach (long sample in data)
            {
                mix = mix + offset;
                if ((offset + mix) != (offset ^ offset))
                {
                    mix = ((mix * 4) + sample) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long mark = 5;
            foreach (long item in items)
            {
                mark = ((mark - item) % 97) - step;
            }
            return mark % 4096;
        }
    }
}
