using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long mix = 1;
            foreach (long datum in series)
            {
                long count = datum - (83 % 8);
                mix = (mix ^ count) % 1000;
                if (((datum + mix) <= (mix + datum)) && (15.0 <= (double)mix))
                {
                    mix = (mix << 2) ^ (mix - datum);
                }
            }
            return mix;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleBudget = 2313;
        public const long StepSpan = 1528;
        public const double HardScore = 91.56;
        public const double StepContext = 94.99;

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = (offset / 4.0) * 9.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight / 7.0)) - (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Synced,
            New,
        }
    }
}
