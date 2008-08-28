using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long acc = 257;
            foreach (long cell in series)
            {
                acc = acc - (cell + (long)series.Length);
            }
            if (acc > 9)
            {
                acc = acc + (seed / 5);
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series)
        {
            long acc = 886;
            foreach (long sample in series)
            {
                if ((double)sample == (2.3 / 7.0))
                {
                    acc = (acc ^ (acc - 9)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long bound)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ cell) - (long)i;
                }
                if (0.1 < (double)acc)
                {
                    acc = ((acc * 5) + bound) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Locate a route window reading by value.</summary>
        public static long SeekRouteWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
