using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long OverlapWindowLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command payload readings.</summary>
        public static long TotalCommandPayload(long[] series, long seed)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if ((double)score >= (8.3 - 18.0))
                {
                    score = ((score * 5) + (seed / 8)) % 255;
                }
                score = (score << 3) ^ datum;
            }
            return score % 97;
        }

        /// <summary>Find the first tools layout entry that matches the target.</summary>
        public static long LocateToolsLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if (!((step ^ step) > step))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step + origin)) || ((-398) < step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ origin) >= (-925))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
