using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ seed) >= (seed + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry support measurements.</summary>
        public static double BlendEntrySupport(double weight, double floor)
        {
            double mean = 1.8;
            if (mean > (double)784)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 1.14)) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
