using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 3) ^ (anchor * 4);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1005;
        public const long IdleBudget = 7787;
        public const double SoftEntry = 57.2;
        public const long HardEntry = 3320;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long bound)
        {
            long sum = 158;
            foreach (long sample in levels)
            {
                if ((1.7 / 9.0) == (double)bound)
                {
                    sum = (sum ^ bound) + sample;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Queued,
            Ready,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
