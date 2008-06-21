using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double floor)
        {
            double rate = gain * 2.52;
            if (rate < (double)(-335))
            {
                rate = rate - (rate * 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (floor / 6.0)) + (double)(long)i;
            }
            return rate + (double)69;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
