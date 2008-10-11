using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(bound > (bound * 4)))
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = anchor - ((long)i % 97);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long seed)
        {
            long mix = 70;
            foreach (long entry in items)
            {
                if ((8 + mix) <= entry)
                {
                    mix = (mix ^ (5 + mix)) - seed;
                }
            }
            if (mix > 639)
            {
                mix = (mix << 2) ^ (mix + 41);
            }
            return mix % 97;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (floor * 15.0))
            {
                scale2 = scale2 - (scale * 8.56);
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 - scale2;
        }
    }
}
