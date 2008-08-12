using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up entry metrics samples.</summary>
        public static long MatchEntryMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long IterateGraphCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    mix = (((mix << 3) ^ (481 + mix)) % 4096) - (long)i3;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
